using FileManager.Foundation.Interfaces;

namespace FileManager
{
    public partial class MenuForm : Form
    {
        private readonly IFileGeneratorService _fileGeneratorService;
        private readonly IFileMergerService _fileMergerService;
        private readonly IFileImporterService _fileImporterService;
        private readonly IDatabaseService _databaseService;



        public MenuForm(
            IFileGeneratorService fileGeneratorService,
            IFileMergerService fileMergerService,
            IFileImporterService fileImporterService,
            IDatabaseService databaseService)
        {
            InitializeComponent();

            _fileGeneratorService = fileGeneratorService;
            _fileMergerService = fileMergerService;
            _fileImporterService = fileImporterService;
            _databaseService = databaseService;
        }



        private async void GenerateFilesButton_Click(object sender, EventArgs e)
        {
            GenerateFilesButton.Enabled = false;

            await _fileGeneratorService.GenerateAsync(
                Convert.ToInt32(FileCountNumericUpDown.Value),
                Convert.ToInt32(LineCountInFileNumericUpDown.Value),
                AppDomain.CurrentDomain.BaseDirectory);

            MessageBox.Show(
                "Files generated!",
                "Message",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);

            GenerateFilesButton.Enabled = true;
        }


        private async void ExecuteButton_Click(object sender, EventArgs e)
        {
            ExecuteButton.Enabled = false;

            var values = await _databaseService.GetIntegerNumbersSumAndFloatNumbersMedianaOrReturnNullAsync();
            if (values == null || values.Count != 2)
            {
                ExecuteButton.Enabled = true;

                return;
            }

            ResultRichTextBox.Text =
                "Sum of integers numbers: " + values[0].Result + "\r\n" +
                "Median of float numbers: " + values[1].Result;
            
            ExecuteButton.Enabled = true;
        }

        private async void MergeFilesButton_Click(object sender, EventArgs e)
        {
            if (openFilesDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            MergeFilesButton.Enabled = false;

            var countRemovedLines = await _fileMergerService.MergeAsync(
                [.. openFilesDialog.FileNames],
                CombinationToRemoveTextBox.Text,
                AppDomain.CurrentDomain.BaseDirectory);

            MessageBox.Show(
                "Files merged.\r\n" +
                "Removed line count: " + countRemovedLines,
                "Message",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);

            MergeFilesButton.Enabled = true;
        }

        private async void ImportFilesButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            ImportFilesButton.Enabled = false;

            await _fileImporterService.ImportDataFromFileAsync(openFileDialog.FileName, (int importedLineCount, int remainingLineCount) =>
            {
                ProgressRichTextBox.Text =
                    "Total: " + (importedLineCount + remainingLineCount) + "\r\n" +
                    "Imported line count: " + importedLineCount + "\r\n" +
                    "Remaining line count: " + remainingLineCount;
            });

            MessageBox.Show(
               "File imported.",
               "Message",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information,
               MessageBoxDefaultButton.Button1,
               MessageBoxOptions.DefaultDesktopOnly);
            
            ImportFilesButton.Enabled = true;
        }
    }
}

namespace FileManager
{
    partial class MenuForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            FileCountLabel = new Label();
            FileCountNumericUpDown = new NumericUpDown();
            GenerateFilesButton = new Button();
            CombinationToRemoveTextBox = new TextBox();
            MergeFilesButton = new Button();
            CombinationToRemoveLabel = new Label();
            LineCountInFileNumericUpDown = new NumericUpDown();
            LineCountInFileLabel = new Label();
            ImportFilesButton = new Button();
            openFilesDialog = new OpenFileDialog();
            openFileDialog = new OpenFileDialog();
            ProgressLabel = new Label();
            ProgressRichTextBox = new RichTextBox();
            ExecuteButton = new Button();
            ResultRichTextBox = new RichTextBox();
            ResultLabel = new Label();
            GenerationGroupBox = new GroupBox();
            FileMergingGroupBox = new GroupBox();
            FileImportingGroupBox = new GroupBox();
            CalcilationGroupBox = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)FileCountNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LineCountInFileNumericUpDown).BeginInit();
            GenerationGroupBox.SuspendLayout();
            FileMergingGroupBox.SuspendLayout();
            FileImportingGroupBox.SuspendLayout();
            CalcilationGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // FileCountLabel
            // 
            FileCountLabel.AutoSize = true;
            FileCountLabel.Location = new Point(9, 39);
            FileCountLabel.Name = "FileCountLabel";
            FileCountLabel.Size = new Size(73, 20);
            FileCountLabel.TabIndex = 0;
            FileCountLabel.Text = "File count";
            // 
            // FileCountNumericUpDown
            // 
            FileCountNumericUpDown.Location = new Point(104, 37);
            FileCountNumericUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            FileCountNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            FileCountNumericUpDown.Name = "FileCountNumericUpDown";
            FileCountNumericUpDown.Size = new Size(196, 27);
            FileCountNumericUpDown.TabIndex = 1;
            FileCountNumericUpDown.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // GenerateFilesButton
            // 
            GenerateFilesButton.Location = new Point(9, 138);
            GenerateFilesButton.Name = "GenerateFilesButton";
            GenerateFilesButton.Size = new Size(291, 37);
            GenerateFilesButton.TabIndex = 2;
            GenerateFilesButton.Text = "Generate";
            GenerateFilesButton.UseVisualStyleBackColor = true;
            GenerateFilesButton.Click += GenerateFilesButton_Click;
            // 
            // CombinationToRemoveTextBox
            // 
            CombinationToRemoveTextBox.Location = new Point(110, 39);
            CombinationToRemoveTextBox.Name = "CombinationToRemoveTextBox";
            CombinationToRemoveTextBox.Size = new Size(187, 27);
            CombinationToRemoveTextBox.TabIndex = 8;
            // 
            // MergeFilesButton
            // 
            MergeFilesButton.Location = new Point(6, 138);
            MergeFilesButton.Name = "MergeFilesButton";
            MergeFilesButton.Size = new Size(293, 37);
            MergeFilesButton.TabIndex = 9;
            MergeFilesButton.Text = "Merge";
            MergeFilesButton.UseVisualStyleBackColor = true;
            MergeFilesButton.Click += MergeFilesButton_Click;
            // 
            // CombinationToRemoveLabel
            // 
            CombinationToRemoveLabel.Location = new Point(4, 39);
            CombinationToRemoveLabel.Name = "CombinationToRemoveLabel";
            CombinationToRemoveLabel.Size = new Size(100, 42);
            CombinationToRemoveLabel.TabIndex = 10;
            CombinationToRemoveLabel.Text = "Combination to remove";
            // 
            // LineCountInFileNumericUpDown
            // 
            LineCountInFileNumericUpDown.Location = new Point(104, 80);
            LineCountInFileNumericUpDown.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            LineCountInFileNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            LineCountInFileNumericUpDown.Name = "LineCountInFileNumericUpDown";
            LineCountInFileNumericUpDown.Size = new Size(196, 27);
            LineCountInFileNumericUpDown.TabIndex = 12;
            LineCountInFileNumericUpDown.Value = new decimal(new int[] { 100000, 0, 0, 0 });
            // 
            // LineCountInFileLabel
            // 
            LineCountInFileLabel.Location = new Point(9, 80);
            LineCountInFileLabel.Name = "LineCountInFileLabel";
            LineCountInFileLabel.Size = new Size(89, 44);
            LineCountInFileLabel.TabIndex = 11;
            LineCountInFileLabel.Text = "Line count in file";
            // 
            // ImportFilesButton
            // 
            ImportFilesButton.Location = new Point(9, 149);
            ImportFilesButton.Name = "ImportFilesButton";
            ImportFilesButton.Size = new Size(293, 37);
            ImportFilesButton.TabIndex = 15;
            ImportFilesButton.Text = "Import";
            ImportFilesButton.UseVisualStyleBackColor = true;
            ImportFilesButton.Click += ImportFilesButton_Click;
            // 
            // openFilesDialog
            // 
            openFilesDialog.Filter = "Text files(*.txt)|*.txt";
            openFilesDialog.Multiselect = true;
            // 
            // openFileDialog
            // 
            openFileDialog.Filter = "Text files(*.txt)|*.txt";
            // 
            // ProgressLabel
            // 
            ProgressLabel.AutoSize = true;
            ProgressLabel.Location = new Point(7, 45);
            ProgressLabel.Name = "ProgressLabel";
            ProgressLabel.Size = new Size(65, 20);
            ProgressLabel.TabIndex = 17;
            ProgressLabel.Text = "Progress";
            // 
            // ProgressRichTextBox
            // 
            ProgressRichTextBox.Location = new Point(108, 45);
            ProgressRichTextBox.Name = "ProgressRichTextBox";
            ProgressRichTextBox.ReadOnly = true;
            ProgressRichTextBox.Size = new Size(192, 98);
            ProgressRichTextBox.TabIndex = 18;
            ProgressRichTextBox.Text = "";
            // 
            // ExecuteButton
            // 
            ExecuteButton.Location = new Point(9, 149);
            ExecuteButton.Name = "ExecuteButton";
            ExecuteButton.Size = new Size(293, 37);
            ExecuteButton.TabIndex = 19;
            ExecuteButton.Text = "Execute";
            ExecuteButton.UseVisualStyleBackColor = true;
            ExecuteButton.Click += ExecuteButton_Click;
            // 
            // ResultRichTextBox
            // 
            ResultRichTextBox.Location = new Point(110, 42);
            ResultRichTextBox.Name = "ResultRichTextBox";
            ResultRichTextBox.ReadOnly = true;
            ResultRichTextBox.Size = new Size(192, 101);
            ResultRichTextBox.TabIndex = 21;
            ResultRichTextBox.Text = "";
            // 
            // ResultLabel
            // 
            ResultLabel.AutoSize = true;
            ResultLabel.Location = new Point(9, 39);
            ResultLabel.Name = "ResultLabel";
            ResultLabel.Size = new Size(49, 20);
            ResultLabel.TabIndex = 20;
            ResultLabel.Text = "Result";
            // 
            // GenerationGroupBox
            // 
            GenerationGroupBox.Controls.Add(FileCountNumericUpDown);
            GenerationGroupBox.Controls.Add(FileCountLabel);
            GenerationGroupBox.Controls.Add(GenerateFilesButton);
            GenerationGroupBox.Controls.Add(LineCountInFileLabel);
            GenerationGroupBox.Controls.Add(LineCountInFileNumericUpDown);
            GenerationGroupBox.Location = new Point(12, 23);
            GenerationGroupBox.Name = "GenerationGroupBox";
            GenerationGroupBox.Size = new Size(315, 190);
            GenerationGroupBox.TabIndex = 22;
            GenerationGroupBox.TabStop = false;
            GenerationGroupBox.Text = "File generation";
            // 
            // FileMergingGroupBox
            // 
            FileMergingGroupBox.Controls.Add(CombinationToRemoveTextBox);
            FileMergingGroupBox.Controls.Add(MergeFilesButton);
            FileMergingGroupBox.Controls.Add(CombinationToRemoveLabel);
            FileMergingGroupBox.Location = new Point(367, 23);
            FileMergingGroupBox.Name = "FileMergingGroupBox";
            FileMergingGroupBox.Size = new Size(314, 190);
            FileMergingGroupBox.TabIndex = 23;
            FileMergingGroupBox.TabStop = false;
            FileMergingGroupBox.Text = "File merging";
            // 
            // FileImportingGroupBox
            // 
            FileImportingGroupBox.Controls.Add(ProgressRichTextBox);
            FileImportingGroupBox.Controls.Add(ImportFilesButton);
            FileImportingGroupBox.Controls.Add(ProgressLabel);
            FileImportingGroupBox.Location = new Point(12, 235);
            FileImportingGroupBox.Name = "FileImportingGroupBox";
            FileImportingGroupBox.Size = new Size(315, 203);
            FileImportingGroupBox.TabIndex = 24;
            FileImportingGroupBox.TabStop = false;
            FileImportingGroupBox.Text = "File importing";
            // 
            // CalcilationGroupBox
            // 
            CalcilationGroupBox.Controls.Add(ResultRichTextBox);
            CalcilationGroupBox.Controls.Add(ExecuteButton);
            CalcilationGroupBox.Controls.Add(ResultLabel);
            CalcilationGroupBox.Location = new Point(367, 235);
            CalcilationGroupBox.Name = "CalcilationGroupBox";
            CalcilationGroupBox.Size = new Size(314, 203);
            CalcilationGroupBox.TabIndex = 25;
            CalcilationGroupBox.TabStop = false;
            CalcilationGroupBox.Text = "Calculation";
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 450);
            Controls.Add(CalcilationGroupBox);
            Controls.Add(FileImportingGroupBox);
            Controls.Add(FileMergingGroupBox);
            Controls.Add(GenerationGroupBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MenuForm";
            Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)FileCountNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)LineCountInFileNumericUpDown).EndInit();
            GenerationGroupBox.ResumeLayout(false);
            GenerationGroupBox.PerformLayout();
            FileMergingGroupBox.ResumeLayout(false);
            FileMergingGroupBox.PerformLayout();
            FileImportingGroupBox.ResumeLayout(false);
            FileImportingGroupBox.PerformLayout();
            CalcilationGroupBox.ResumeLayout(false);
            CalcilationGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label FileCountLabel;
        private NumericUpDown FileCountNumericUpDown;
        private Button GenerateFilesButton;
        private TextBox CombinationToRemoveTextBox;
        private Button MergeFilesButton;
        private Label CombinationToRemoveLabel;
        private NumericUpDown LineCountInFileNumericUpDown;
        private Label LineCountInFileLabel;
        private Button ImportFilesButton;
        private OpenFileDialog openFilesDialog;
        private OpenFileDialog openFileDialog;
        private Label ProgressLabel;
        private RichTextBox ProgressRichTextBox;
        private Button ExecuteButton;
        private RichTextBox ResultRichTextBox;
        private Label ResultLabel;
        private GroupBox GenerationGroupBox;
        private GroupBox FileMergingGroupBox;
        private GroupBox FileImportingGroupBox;
        private GroupBox CalcilationGroupBox;
    }
}

using FileManager.Foundation.Interfaces;

namespace FileManager.Foundation
{
    /// <summary>
    /// Сервис для генерации файлов 
    /// </summary>
    public class FileGeneratorService(ILineService lineService) : IFileGeneratorService
    {
        private const string LINE_BREAK = "\r\n";

        private readonly ILineService _lineService = lineService;



        public async Task GenerateAsync(int fileCount, int lineCount, string folderPath)
        {
            var tasks = new Task[fileCount];
            for (var i = 0; i < tasks.Length; i++)
            {
                tasks[i] = Task.Run(async () =>
                {
                    await GenerateFileAsync(lineCount, folderPath);
                });
            }

            await Task.WhenAll(tasks);
        }

        private async Task GenerateFileAsync(int lineCount, string folderPath)
        {
            using var streamWriter = new StreamWriter(folderPath + "/" + Path.GetRandomFileName() + ".txt");

            var lines = new string[lineCount];
            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = _lineService.Generate();
            }

            await streamWriter.WriteAsync(string.Join(LINE_BREAK, lines));
        }

    }
}

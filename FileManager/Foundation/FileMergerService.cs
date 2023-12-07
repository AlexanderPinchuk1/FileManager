using FileManager.Foundation.Interfaces;

namespace FileManager.Foundation
{
    /// <summary>
    /// Сервис для слияния файлов в один, с удалением строк, содержащую заданную комбинацию 
    /// </summary>
    public class FileMergerService : IFileMergerService
    {
        private const string LINE_BREAK = "\r\n";



        public async Task<int> MergeAsync(List<string> filePathes, string combination, string folderPath)
        {
            using var sw = new StreamWriter(
                folderPath +
                "/mergeResult" +
                Path.GetRandomFileName() +
                ".txt");
            var textWriter = TextWriter.Synchronized(sw);
            var tasks = new Task<int>[filePathes.Count];

            for (var i = 0; i < tasks.Length; i++)
            {
                var filePath = filePathes[i];

                tasks[i] = Task.Run(async () =>
                {
                    return await MergeFileAsync(textWriter, filePath, combination);
                });
            }

            return (await Task.WhenAll(tasks)).Sum();
        }

        private static async Task<int> MergeFileAsync(TextWriter textWriter, string filePath, string combination)
        {
            using var reader = new StreamReader(filePath);
            var lines = (await reader.ReadToEndAsync())
                .Split(LINE_BREAK).ToList();

            var removedLineCount = combination == "" 
                ? 0 
                : lines.RemoveAll(line => line.Contains(combination));

            await textWriter.WriteLineAsync(string.Join(LINE_BREAK, lines));

            return removedLineCount;
        }
    }
}

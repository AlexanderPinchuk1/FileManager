namespace FileManager.Foundation.Interfaces
{
    public interface IFileGeneratorService
    {
        public Task GenerateAsync(int fileCount, int lineCount, string folderPath);
    }
}

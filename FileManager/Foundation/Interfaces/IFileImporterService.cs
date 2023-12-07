namespace FileManager.Foundation.Interfaces
{
    public interface IFileImporterService
    {
        public Task ImportDataFromFileAsync(string filePath, Action<int, int> notifyer);
    }
}

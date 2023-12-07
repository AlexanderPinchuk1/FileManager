namespace FileManager.Foundation.Interfaces
{
    public interface IFileMergerService
    {
        public Task<int> MergeAsync(List<string> filePathes, string combination, string folderPath);
    }
}

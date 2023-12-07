namespace FileManager.Foundation.Interfaces
{
    public interface INotificationService
    {
        public void Notify();

        public int GetImportedLineCount();
        
        public void UpdateImportedAndRemaningLineCount(int count);

        public void InitNotifyData(Action<int, int> notifyer, int importedLineCount, int remainingLineCount);
    }
}

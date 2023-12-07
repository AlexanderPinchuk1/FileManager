using FileManager.Foundation.Interfaces;

namespace FileManager.Foundation
{
    /// <summary>
    /// Сервис для уведомления об изменении количества импортированных строк в БД
    /// </summary>
    public class NotificationService : INotificationService
    {
        private Action<int, int>? Notifyer;
        private int ImportedLineCount;
        private int RemainingLineCount;



        public void InitNotifyData(
            Action<int, int> notifyer, 
            int importedLineCount, 
            int remainingLineCount)
        {
            Notifyer = notifyer;
            ImportedLineCount = importedLineCount;
            RemainingLineCount = remainingLineCount;
        }

        public int GetImportedLineCount()
        {
           return ImportedLineCount;
        }

        public void UpdateImportedAndRemaningLineCount(int count)
        {
            ImportedLineCount++;
            RemainingLineCount--;
        }
        public void Notify()
        {
            Notifyer?.Invoke(ImportedLineCount, RemainingLineCount);
        }
    }
}

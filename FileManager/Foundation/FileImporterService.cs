using FileManager.Foundation.Interfaces;
using FileManager.Model;
using FileManager.Repositories;

namespace FileManager.Foundation
{
    /// <summary>
    /// Сервис для импорта содрежимого файла в БД
    /// </summary>
    public partial class FileImporterService(
        IDatabaseService databaseService,
        ILineService lineService, 
        INotificationService notificationService) : IFileImporterService
    {
        private const string LINE_BREAK = "\r\n";
        private const string VALUE_SEPARATOR = "||";
        private const int ITEM_COUNT_FOR_SAVE = 1000;

        private readonly ILineService _lineService = lineService;
        private readonly INotificationService _notificationService = notificationService;
        private readonly IDatabaseService _databaseService = databaseService;



        public async Task ImportDataFromFileAsync(string filePath, Action<int,int> notifyer)
        {
            var lines = await ReadLinesFromFileAsync(filePath);
            _notificationService.InitNotifyData(notifyer, 0, lines.Count);
            
            foreach (var line in lines)
            {
                if (!_lineService.IsMatchLinePattern(line))
                {
                    continue;
                }

                await _databaseService.AddDataEntityIntoContextAsync(CreateDataEntityByLine(line));
               
                _notificationService.UpdateImportedAndRemaningLineCount(1);
                await SaveEntitiesIfTheyAreRequiredCountAndNotifyAsync();                
            }

            await SaveRemainigEntitiesIfTheyExistAndNotifyAsync();
        }

        private async Task SaveRemainigEntitiesIfTheyExistAndNotifyAsync()
        {
            if (_notificationService.GetImportedLineCount() % ITEM_COUNT_FOR_SAVE != 0)
            {
                await SaveDataAndNotifyAsync();
            }
        }

        private async Task SaveEntitiesIfTheyAreRequiredCountAndNotifyAsync()
        {
            if (_notificationService.GetImportedLineCount()% ITEM_COUNT_FOR_SAVE == 0)
            {
                await SaveDataAndNotifyAsync();
            }
        }

        private static Data CreateDataEntityByLine(string line)
        {
            var values = line.Split(VALUE_SEPARATOR);

            return new Data()
            {
                Id = Guid.NewGuid(),
                Date = Convert.ToDateTime(values[0]),
                LatinString = values[1],
                RusString = values[2],
                IntegerNumber = Convert.ToInt32(values[3]),
                FloatNumber = Convert.ToDecimal(values[4])
            };
        }

        private async Task<List<string>> ReadLinesFromFileAsync(string filePath)
        {
            using var reader = new StreamReader(filePath);
            return
            [
                .. (await reader.ReadToEndAsync()).Split(LINE_BREAK),
            ];
        }

        private async Task SaveDataAndNotifyAsync()
        {
            await _databaseService.SaveChangesAsync();
            _notificationService.Notify();
        }
    }
}

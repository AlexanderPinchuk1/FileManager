using FileManager.Domain;
using FileManager.Model;

namespace FileManager.Foundation.Interfaces
{
    public interface IDatabaseService
    {
        public Task<List<IntNumSumAndFloatNumMedianaResult>> GetIntegerNumbersSumAndFloatNumbersMedianaOrReturnNullAsync();

        public Task AddDataEntityIntoContextAsync(Data data);

        public Task SaveChangesAsync(); 
    }
}

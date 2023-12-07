using FileManager.Domain;
using FileManager.Foundation.Interfaces;
using FileManager.Model;
using FileManager.Repositories;
using Microsoft.EntityFrameworkCore;

namespace FileManager.Foundation
{
    /// <summary>
    /// Сервис для работы с БД
    /// </summary>
    public class DatabaseService(FileManagerDbContext fileManagerDbContext) : IDatabaseService
    {
        private readonly FileManagerDbContext _fileManagerDbContext = fileManagerDbContext;



        public async Task<List<IntNumSumAndFloatNumMedianaResult>> GetIntegerNumbersSumAndFloatNumbersMedianaOrReturnNullAsync()
        {
            return await _fileManagerDbContext
                .GetIntegerNumbersSumAndFloatNumbersMediana().Take(2).ToListAsync();
        }

        public async Task AddDataEntityIntoContextAsync(Data data)
        {
            await _fileManagerDbContext.Set<Data>().AddAsync(data);
        }

        public async Task SaveChangesAsync()
        {
            await _fileManagerDbContext.SaveChangesAsync();
        }
    }
}

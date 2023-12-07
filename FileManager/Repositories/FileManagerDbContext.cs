using FileManager.Domain;
using FileManager.Model;
using Microsoft.EntityFrameworkCore;

namespace FileManager.Repositories
{
    /// <summary>
    /// Контекст для работы с БД
    /// </summary>
    public class FileManagerDbContext : DbContext
    {
        public DbSet<Data> Data { get; set; }

        public IQueryable<IntNumSumAndFloatNumMedianaResult> GetIntegerNumbersSumAndFloatNumbersMediana() => 
            FromExpression(() => GetIntegerNumbersSumAndFloatNumbersMediana());



        public FileManagerDbContext(DbContextOptions<FileManagerDbContext> options)
            : base(options)
        {
            Database.Migrate();
        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.HasDbFunction(() => GetIntegerNumbersSumAndFloatNumbersMediana());
            modelBuilder.ApplyConfigurationsFromAssembly(
                assembly: typeof(Data).Assembly);
        }
    }
}

using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace FileManager.Model
{
    /// <summary>
    /// Модель для хранения информации из строк файла
    /// </summary>
    public class Data
    {
        public Guid Id { get; set; }

        public DateTime Date { get; set; }

        public string? LatinString { get; set; }

        public string? RusString { get; set; }

        public int IntegerNumber { get; set; }

        public decimal FloatNumber { get; set; }
    }


    /// <summary>
    /// Конфигурация модели для БД
    /// </summary>
    public class DataConfig : IEntityTypeConfiguration<Data>
    {
        public void Configure(EntityTypeBuilder<Data> builder)
        {
            builder.HasKey(data => data.Id);
            builder.Property(data => data.Id).HasDefaultValueSql("newsequentialid()");
            builder.Property(data => data.LatinString).IsRequired().HasMaxLength(100);
            builder.Property(data => data.RusString).IsRequired().HasMaxLength(100);
            builder.Property(data => data.FloatNumber).HasPrecision(30, 20);
            builder.ToTable(name: "Data");
        }
    }
}

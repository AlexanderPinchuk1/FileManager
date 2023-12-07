using FileManager.Foundation;
using FileManager.Foundation.Interfaces;
using FileManager.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FileManager
{
    internal static class Program
    {
        public static IServiceProvider? ServiceProvider { get; private set; }



        [STAThread]
        static void Main()
        {
            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;
            Application.Run(ServiceProvider.GetRequiredService<MenuForm>());
        }

        static IHostBuilder CreateHostBuilder()
        {
            var builder = new ConfigurationBuilder();
            var config = builder.Build();

            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddDbContext<FileManagerDbContext>(options =>
                    {
                        options.UseSqlServer(System.Configuration
                            .ConfigurationManager
                            .ConnectionStrings["DefaultConnection"]
                            .ConnectionString);
                        options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
                    }, ServiceLifetime.Transient);

                    services.AddTransient<MenuForm>();
                    services.AddTransient<IValueGenerator, ValueGenerator>();
                    services.AddTransient<ILineService, LineService>();
                    services.AddTransient<IFileGeneratorService, FileGeneratorService>();
                    services.AddTransient<IFileMergerService, FileMergerService>();
                    services.AddTransient<INotificationService, NotificationService>();
                    services.AddTransient<IFileImporterService, FileImporterService>();
                    services.AddTransient<IDatabaseService, DatabaseService>();
                });
        }
    }
}
using DataAccessLibrary.Data;
using DataAccessLibrary.Databases;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.IO;



namespace DocumentManageApp.Desktop
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var builder = new HostBuilder()
                .ConfigureAppConfiguration((config) =>
                {
                    config.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                })
                .ConfigureServices((hostContext, services) =>
                {
                    services
                        .AddTransient<IDatabaseData, SqlData>()
                        .AddTransient<ISqlDataAccess, SqlDataAccess>()
                        .AddTransient<DocumentApplication>()
                        .AddTransient<AddDocumentForm>();
                });

            var host = builder.Build();

            using var scope = host.Services.CreateScope();

            var services = scope.ServiceProvider;

            try
            {
                var documentApplication = services.GetRequiredService<DocumentApplication>();
                documentApplication.ShowDialog();
            }
            catch (Exception ex)
            {
                Console.WriteLine($" erro occurd , {ex}");
            }

        }

    }
}
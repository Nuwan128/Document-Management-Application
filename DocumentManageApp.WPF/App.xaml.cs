using DataAccessLibrary.Data;
using DataAccessLibrary.Databases;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace DocumentManageApp.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            var builder = new HostBuilder()
                .ConfigureAppConfiguration((config) =>
                {
                    config.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                    //config.AddUserSecrets<App>();
                })
                .ConfigureServices((hostContext, services) =>
                {
                    services
                        .AddTransient<ISqlDataAccess, SqlDataAccess>()
                        .AddTransient<IDatabaseData, SqlData>()
                        .AddTransient<MainWindow>()
                        .AddTransient<ViewDocument>();

                });
            var host = builder.Build();

            using var scope = host.Services.CreateScope();

            var services = scope.ServiceProvider;
            try
            {
                var mainWindow = services.GetRequiredService<MainWindow>();
                mainWindow.ShowDialog();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error - {ex}");
            }

        }
    }
}

using DataAccessLibrary.Data;
using DataAccessLibrary.Databases;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
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


            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            var configuration = builder.Build();

            var services = new ServiceCollection()
                .AddTransient<IDatabaseData, SqlData>()
                .AddTransient<ISqlDataAccess, SqlDataAccess>()
                .AddTransient<DocumentApplication>()
                .AddTransient<AddDocumentForm>()
                .AddSingleton<IConfiguration>(configuration)
                .BuildServiceProvider();

            //services.GetRequiredService<AddDocumentForm>();
            // Launch the application
            Application.Run(services.GetRequiredService<DocumentApplication>());



        }

    }
}
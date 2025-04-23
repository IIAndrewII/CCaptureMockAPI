using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using CCaptureWinForm.Infrastructure.Services;
using CCaptureWinForm.Core.Interfaces;

namespace CCaptureWinForm
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Initialize application configuration
            ApplicationConfiguration.Initialize();

            // Build configuration
            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("DOTNET_ENVIRONMENT") ?? "Production"}.json", optional: true)
                .Build();

            // Set up dependency injection
            var services = new ServiceCollection();
            ConfigureServices(services, configuration);

            // Build the service provider
            var serviceProvider = services.BuildServiceProvider();

            // Run the application
            Application.Run(serviceProvider.GetRequiredService<MainForm>());
        }

        private static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton(configuration);
            services.AddScoped<IDatabaseService, DatabaseService>();
            services.AddTransient<MainForm>();
        }
    }
}

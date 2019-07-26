using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;

namespace LoggingExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .UseStartup<Startup>()
            .ConfigureLogging(loggingConfiguration => loggingConfiguration.ClearProviders())
            .UseSerilog((hostingContext, loggerConfiguration) => 
                loggerConfiguration.ReadFrom.Configuration(hostingContext.Configuration));
    }
}

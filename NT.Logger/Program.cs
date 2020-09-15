using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using System;

namespace NT.Logger
{
    public class LoggerDebug
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
             .WriteTo.Seq("http://localhost:5341")
             .WriteTo.Console()
             .CreateLogger();

            new HostBuilder()
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddHostedService<IHostedService>();
                })
                .ConfigureLogging((hostContext, logging) =>
                {
                    logging.AddSerilog();
                })
                .Build()
                .Run();
        }
    }
}

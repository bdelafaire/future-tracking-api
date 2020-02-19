using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Sinks.SumoLogic;

namespace Recette.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
              .WriteTo.SumoLogic("https://endpoint1.collection.eu.sumologic.com/receiver/v1/http/ZaVnC4dhaV0Wn6Zzb0ulfpXgpUvw0u1AeNbCeFOmxk5JlBET94NOwz922152H4thfO_0bLFXEwAWTeZmqJ5O88CS0QsVR9ghq6CuLQ4M7A_-a9rvb040sA==")
              .Enrich.FromLogContext()
              .CreateLogger();
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}

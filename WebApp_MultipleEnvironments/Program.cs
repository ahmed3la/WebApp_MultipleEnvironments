using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_MultipleEnvironments
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });


        public static void AddAppConfiguration(HostBuilderContext hostingContext, IConfigurationBuilder config) 
        {
            var env = hostingContext.HostingEnvironment;
            config.AddJsonFile($"appsettings.json", optional: false).AddIniFile($"appsettings.{env.EnvironmentName}.json", true);

            if (env.IsDevelopment())
            {
                 
            }
             
        }



















    }
}

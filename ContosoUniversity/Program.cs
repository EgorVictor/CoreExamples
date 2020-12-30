using ContosoUniversity.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IHost host = CreateHostBuilder(args).Build();
            CreateDBIfExists(host);
            host.Run();
        }

        private static void CreateDBIfExists(IHost host)
        {
            using (var scope= host.Services.CreateScope())
            {
                IServiceProvider serviceProvider = scope.ServiceProvider;
                try
                {
                    var schoolConext = serviceProvider.GetRequiredService<SchoolContext>();
                    //schoolConext.Database.EnsureCreated();
                    DbInitializer.Initialize(schoolConext);
                }
                catch (Exception)
                {

                    ILogger<Program> logger = serviceProvider.GetRequiredService<ILogger<Program>>();
                    logger.LogError("An error occurred creating the DB.");
                }
                
            }
        }
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}

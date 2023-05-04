using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ConsoleApp1.IOC
{
    public static class Startup
    {

        public static IHostBuilder CreateHostBuilder()
        {
            
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, service) =>
                {
                    var pigreco = double.Parse(context.Configuration["PiGreco"]);
                    
                    
                    service.AddSingleton<ICalc, Sum>();


                    service.AddSingleton<IIncrement>(_ => new Increment(5));
                    service.AddScoped<Circle>();
                    service.AddTransient<ICircle>(_ => new CircleBis(pigreco));
                    

                });

        }
    }
}

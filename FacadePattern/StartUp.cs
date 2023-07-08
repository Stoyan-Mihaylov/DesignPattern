using FacadePattern.Core;
using FacadePattern.Models;
using FacadePattern.Models.Contracts;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FacadePattern
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var host = CreateHosting(args).Build();
            host.Services.GetService<ICarEngine>()!.Start();
            Console.WriteLine();
            host.Services.GetService<ICarEngine>()!.Stop();
        }

        public static IHostBuilder CreateHosting(string[] args)
            => Host.CreateDefaultBuilder(args)
            .ConfigureServices((context, services) =>
            {
                services
                .AddTransient<ICarEngine, CarEngine>()
                .AddSingleton<IAirflowSensor, AirflowSensor>()
                .AddSingleton<ICoolingPump, CoolingPump>()
                .AddSingleton<IEngineStarter, EngineStarter>()
                .AddSingleton<IFuelPump, FuelPump>();
            });
    }
}
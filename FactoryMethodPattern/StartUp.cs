using FactoryMethodPattern.Core;
using FactoryMethodPattern.Factories;
using FactoryMethodPattern.Factories.Contracts;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FactoryMethodPattern
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var host = CreateHosting(args).Build();
            host.Services.GetService<IEngine>()!.Run();
        }

        public static IHostBuilder CreateHosting(string[] args)
            => Host.CreateDefaultBuilder(args)
            .ConfigureServices((context, services) =>
            {
                services
                .AddTransient<IEngine, Engine>()
                .AddTransient<IAirDeliveryTrackerFactory, AirDeliveryTrackerFactory>()
                .AddTransient<ISeaDeliveryTrackerFactory, SeaDeliveryTrackerFactory>()
                .AddTransient<ITruckDeliveryTrackerFactory, TruckDeliveryTrackerFactory>();
            });
    }
}
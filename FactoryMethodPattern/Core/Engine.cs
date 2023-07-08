using FactoryMethodPattern.Factories.Contracts;
using System;

namespace FactoryMethodPattern.Core
{
    public class Engine : IEngine
    {
        private readonly ITruckDeliveryTrackerFactory _truckDeliveryTrackerFactory;
        private readonly ISeaDeliveryTrackerFactory _seaDeliveryTrackerFactory;
        private readonly IAirDeliveryTrackerFactory _airDeliveryTrackerFactory;

        public Engine(
            ITruckDeliveryTrackerFactory truckDeliveryTrackerFactory,
            ISeaDeliveryTrackerFactory seaDeliveryTrackerFactory,
            IAirDeliveryTrackerFactory airDeliveryTrackerFactory)
        {
            _truckDeliveryTrackerFactory = truckDeliveryTrackerFactory;
            _seaDeliveryTrackerFactory = seaDeliveryTrackerFactory;
            _airDeliveryTrackerFactory = airDeliveryTrackerFactory;
        }
        public void Run()
        {
            var groundDelivery = _truckDeliveryTrackerFactory.CreateDelivery();
            var deliveryByTruck = groundDelivery.GetDeliveryMethod();
            Console.WriteLine(deliveryByTruck);

            var seaDelivery = _seaDeliveryTrackerFactory.CreateDelivery();
            var deliveryByShip = seaDelivery.GetDeliveryMethod();
            Console.WriteLine(deliveryByShip);

            var airDelivery = _airDeliveryTrackerFactory.CreateDelivery();
            var deliveryByPlane = airDelivery.GetDeliveryMethod();
            Console.WriteLine(deliveryByPlane);
        }
    }
}

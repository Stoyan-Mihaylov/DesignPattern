using FactoryMethodPattern.Factories.Contracts;
using FactoryMethodPattern.Models;
using FactoryMethodPattern.Models.Contracts;

namespace FactoryMethodPattern.Factories
{
    public class TruckDeliveryTrackerFactory : ITruckDeliveryTrackerFactory
    {
        public IPackageDelivery CreateDelivery()
        {
            return new TruckDelivery();
        }
    }
}

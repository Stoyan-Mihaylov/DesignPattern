using FactoryMethodPattern.Factories.Contracts;
using FactoryMethodPattern.Models;
using FactoryMethodPattern.Models.Contracts;

namespace FactoryMethodPattern.Factories
{
    public class AirDeliveryTrackerFactory : IAirDeliveryTrackerFactory
    {
        public IPackageDelivery CreateDelivery()
        {
            return new PlaneDelivery();
        }
    }
}

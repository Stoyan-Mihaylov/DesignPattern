using FactoryMethodPattern.Factories.Contracts;
using FactoryMethodPattern.Models;
using FactoryMethodPattern.Models.Contracts;

namespace FactoryMethodPattern.Factories
{
    public class SeaDeliveryTrackerFactory : ISeaDeliveryTrackerFactory
    {
        public IPackageDelivery CreateDelivery()
        {
            return new ShipDelivery();
        }
    }
}

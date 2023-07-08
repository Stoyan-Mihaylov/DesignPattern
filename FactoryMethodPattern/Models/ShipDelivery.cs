using FactoryMethodPattern.Models.Contracts;

namespace FactoryMethodPattern.Models
{
    public class ShipDelivery : IPackageDelivery
    {
        private const string PackageDeliveredByShip = "Package delivered by ship.";
        public string GetDeliveryMethod()
        {
            return PackageDeliveredByShip;
        }
    }
}

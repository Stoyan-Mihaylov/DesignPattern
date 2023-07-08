using FactoryMethodPattern.Models.Contracts;

namespace FactoryMethodPattern.Models
{
    public class TruckDelivery : IPackageDelivery
    {
        private const string PackageDeliveredByTruck = "Package delivered by truck.";
        public string GetDeliveryMethod()
        {
            return PackageDeliveredByTruck;
        }
    }
}

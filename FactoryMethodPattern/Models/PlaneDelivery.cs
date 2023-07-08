using FactoryMethodPattern.Models.Contracts;

namespace FactoryMethodPattern.Models
{
    public class PlaneDelivery : IPackageDelivery
    {
        private const string PackageDeliveredByPlane = "Package delivered by plane.";
        public string GetDeliveryMethod()
        {
            return PackageDeliveredByPlane;
        }
    }
}

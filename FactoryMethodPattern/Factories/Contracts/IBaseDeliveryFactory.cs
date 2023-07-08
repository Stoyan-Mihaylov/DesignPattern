using FactoryMethodPattern.Models.Contracts;

namespace FactoryMethodPattern.Factories.Contracts
{
    public interface IBaseDeliveryFactory
    {
        public IPackageDelivery CreateDelivery();
    }
}

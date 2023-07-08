using ObserverPattern.Models.Contracts;

namespace Observer.Pattern.Models.Contracts
{
    public interface ISubject
    {
        public void SubscribeCustomer(ICustomerObserver customer);

        public void UnsubscribeCustomer(ICustomerObserver customer);

        public void NotifyCustomers();
    }
}

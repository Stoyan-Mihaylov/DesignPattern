using Observer.Pattern.Models.Contracts;

namespace ObserverPattern.Models.Contracts
{
    public interface ICustomerObserver : IObserver
    {
        public string FullName { get; set; }

        public decimal TotalAmount { get; set; }
    }
}

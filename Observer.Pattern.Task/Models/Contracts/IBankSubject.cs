using Observer.Pattern.Models.Contracts;

namespace ObserverPattern.Models.Contracts
{
    public interface IBankSubject : ISubject
    {
        public decimal Tax { get; }
        public void ChangeBankTax(decimal tax);
    }
}

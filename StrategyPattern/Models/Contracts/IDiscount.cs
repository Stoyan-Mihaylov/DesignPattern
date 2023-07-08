namespace StrategyPattern.Models.Contracts
{
    public interface IDiscount
    {
        public decimal GetDiscount(decimal purchases);
    }
}

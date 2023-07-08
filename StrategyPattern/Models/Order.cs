using StrategyPattern.Models.Contracts;

namespace StrategyPattern.Models
{
    public class Order
    {
        private IDiscount _discount;
        public void SetDiscount(IDiscount discount)
        {
            _discount = discount;
        }

        public decimal ExecuteDiscount(decimal purchases)
        {
            return _discount.GetDiscount(purchases);
        }
    }
}

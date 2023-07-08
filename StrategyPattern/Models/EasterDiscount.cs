using StrategyPattern.Common;
using StrategyPattern.Models.Contracts;

namespace StrategyPattern.Models
{
    public class EasterDiscount : IDiscount
    {
        private const decimal TreePercentDiscount = 0.97m;
        public decimal GetDiscount(decimal purchases)
        {
            if (purchases > DiscountConstants.AmountRequiredForDiscount)
            {
                return purchases * TreePercentDiscount;
            }

            return purchases;
        }
    }
}

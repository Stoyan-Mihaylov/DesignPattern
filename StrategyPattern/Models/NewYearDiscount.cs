using StrategyPattern.Common;
using StrategyPattern.Models.Contracts;

namespace StrategyPattern.Models
{
    public class NewYearDiscount : IDiscount
    {
        private const decimal OnePercentDiscount = 0.99m;
        public decimal GetDiscount(decimal purchases)
        {
            if (purchases > DiscountConstants.AmountRequiredForDiscount)
            {
                return purchases * OnePercentDiscount;
            }

            return purchases;
        }
    }
}


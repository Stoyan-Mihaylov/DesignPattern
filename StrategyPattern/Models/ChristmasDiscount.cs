using StrategyPattern.Common;
using StrategyPattern.Models.Contracts;

namespace StrategyPattern.Models
{
    public class ChristmasDiscount : IDiscount
    {
        private const decimal FivePercentDiscount = 0.95m;
        public decimal GetDiscount(decimal purchases)
        {
            if (purchases > DiscountConstants.AmountRequiredForDiscount)
            {
                return purchases * FivePercentDiscount;
            }

            return purchases;
        }
    }
}

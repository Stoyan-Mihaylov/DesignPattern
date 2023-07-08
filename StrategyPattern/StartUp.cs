using StrategyPattern.Models;
using System;

namespace StrategyPattern
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Order christmasOrder = new Order();
            Order easterOrder = new Order();
            Order newYearOrder = new Order();

            christmasOrder.SetDiscount(new ChristmasDiscount());

            easterOrder.SetDiscount(new EasterDiscount());

            newYearOrder.SetDiscount(new NewYearDiscount());

            var NewYearOrderPurchasesAmount = 150m;
            var purchasesWithNewYearDiscount = newYearOrder.ExecuteDiscount(NewYearOrderPurchasesAmount);

            var EasterOrderPurchasesAmount = 150m;
            var purchasesWithEasterDiscount = easterOrder.ExecuteDiscount(EasterOrderPurchasesAmount);

            var ChristmasOrderPurchasesAmount = 150m;
            var purchasesWithChristmasDiscount = christmasOrder.ExecuteDiscount(ChristmasOrderPurchasesAmount);

            Console.WriteLine(purchasesWithChristmasDiscount);
            Console.WriteLine(purchasesWithEasterDiscount);
            Console.WriteLine(purchasesWithNewYearDiscount);

            Console.ReadLine();
        }
    }
}
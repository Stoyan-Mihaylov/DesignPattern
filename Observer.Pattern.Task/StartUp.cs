using Observer.Pattern.Models;
using ObserverPattern.Models.Contracts;
using System;

namespace Observer.Pattern
{
    public class StartUp
    {
        private const string WriteChangeInCurrentFee = "Type a change in the current fee: ";

        public static void Main(string[] args)
        {
            var initialBankTax = 2.7m;
            IBankSubject bank = new Bank(initialBankTax);

            var peshoFullName = "Pesho Zelyazkov";
            ICustomerObserver customerPesho = new Customer(peshoFullName);
            bank.SubscribeCustomer(customerPesho);

            var kamenFullName = "Kamen Zdravkov";
            ICustomerObserver customerKamen = new Customer(kamenFullName);
            bank.SubscribeCustomer(customerKamen);

            var dimitrichkoFullName = "Dimitrichko Mihaylov";
            ICustomerObserver customerDimitrichko = new Customer(dimitrichkoFullName);
            bank.SubscribeCustomer(customerDimitrichko);

            Console.WriteLine();
            Console.WriteLine($"Bank tax current state : {bank.Tax}%");
            Console.WriteLine();
            bank.UnsubscribeCustomer(customerDimitrichko);

            Console.WriteLine();
            Console.Write($"{WriteChangeInCurrentFee}");
            decimal increaseInBankTax = decimal.Parse(Console.ReadLine());
            bank.ChangeBankTax(increaseInBankTax);

            Console.WriteLine();
            Console.Write($"{WriteChangeInCurrentFee}");
            decimal secondIncreaseInBankTax = decimal.Parse(Console.ReadLine());
            bank.ChangeBankTax(secondIncreaseInBankTax);
            Console.Read();
        }
    }
}
using ObserverPattern.Models.Contracts;
using System;

namespace Observer.Pattern.Models
{
    public class Customer : ICustomerObserver
    {
        public Customer(string fullName, decimal totalAmount = 0)
        {
            FullName = fullName;
            TotalAmount = totalAmount;
        }
        public string FullName { get; set; }

        public decimal TotalAmount { get; set; }

        public void Update(decimal tax)
        {
            Console.WriteLine($"Hello {FullName}, the tax has been changed to {tax}%");
        }
    }
}

using ObserverPattern.Models.Contracts;
using System;
using System.Collections.Generic;

namespace Observer.Pattern.Models
{
    public class Bank : IBankSubject
    {
        private List<ICustomerObserver> _customers;
        private decimal _tax;

        private Bank()
        {
            _customers = new List<ICustomerObserver>();
        }

        public Bank(decimal tax)
            : this()
        {
            _tax = tax;
        }

        public decimal Tax { get => _tax; }

        public void ChangeBankTax(decimal tax)
        {
            _tax = tax;
            NotifyCustomers();
        }

        public void SubscribeCustomer(ICustomerObserver customer)
        {
            Console.WriteLine($"Customer subscribed {customer.FullName}");
            _customers.Add(customer);
        }

        public void UnsubscribeCustomer(ICustomerObserver customer)
        {
            Console.WriteLine($"Customer unsubscribed {customer.FullName}");
            _customers.Remove(customer);
        }

        public void NotifyCustomers()
        {
            Console.WriteLine();
            foreach (ICustomerObserver customer in _customers)
            {
                customer.Update(_tax);
            }
        }
    }
}

using DecoratorPattern.Models;
using DecoratorPattern.Models.Contracts;
using System;
using System.Collections.Generic;

namespace DecoratorPattern
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var dimitrichkoName = "Dimitrichko";
            var dimitrichkoSalary = 3000m;
            var dimitrichkoHoursOfWork = 200;

            var goshoName = "Gosho";
            var goshoSalary = 2000m;
            var goshoHoursOfWork = 160;

            Employee dimitrichkoEmployee = new Employee(dimitrichkoName, dimitrichkoSalary, dimitrichkoHoursOfWork);
            Employee goshoEmployee = new Employee(goshoName, goshoSalary, goshoHoursOfWork);

            var employees = new List<Employee>()
            {
                dimitrichkoEmployee,
                goshoEmployee
            };

            ISalaryCalculator salaryCalculator = new SalaryCalculator();
            salaryCalculator.CalculateSalaries(employees);

            Console.WriteLine("Salary calculated without bonuses:");
            foreach (var employee in employees)
            {
                Console.WriteLine($"\t Name: {employee.Name}, Salary: {employee.TotalAmount:f2}, HoursOfWork: {employee.HoursOfWork}");
            }

            foreach (var employee in employees)
            {
                employee.TotalAmount = 0;
            }

            ISalaryCalculator employeeSalaryCalculator = new BonusSalaryCalculator(salaryCalculator);
            employeeSalaryCalculator.CalculateSalaries(employees);

            Console.WriteLine();
            Console.WriteLine("Salary calculated with bonuses:");
            foreach (var employee in employees)
            {
                Console.WriteLine($"\t Name: {employee.Name}, Salary: {employee.TotalAmount:f2}, HoursOfWork: {employee.HoursOfWork}");
            }
        }
    }
}
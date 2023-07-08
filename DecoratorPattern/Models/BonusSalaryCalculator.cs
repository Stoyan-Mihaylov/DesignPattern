using DecoratorPattern.Models.Contracts;
using System.Collections.Generic;

namespace DecoratorPattern.Models
{
    public class BonusSalaryCalculator : ISalaryCalculator
    {
        protected ISalaryCalculator _salaryCalculator;

        public BonusSalaryCalculator(ISalaryCalculator salaryCalculator)
        {
            _salaryCalculator = salaryCalculator;
        }

        public void CalculateSalaries(IEnumerable<Employee> employees)
        {
            _salaryCalculator.CalculateSalaries(employees);

            var bonusSalary = 200m;

            foreach (var employee in employees)
            {
                employee.TotalAmount += bonusSalary;
            }
        }
    }
}

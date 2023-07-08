using System.Collections.Generic;

namespace DecoratorPattern.Models.Contracts
{
    public interface ISalaryCalculator
    {
        public void CalculateSalaries(IEnumerable<Employee> employees);
    }
}

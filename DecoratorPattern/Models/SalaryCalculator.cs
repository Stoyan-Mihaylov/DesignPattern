using DecoratorPattern.Models.Contracts;
using System;
using System.Collections.Generic;

namespace DecoratorPattern.Models
{
    public class SalaryCalculator : ISalaryCalculator
    {
        public void CalculateSalaries(IEnumerable<Employee> employees)
        {
            var today = DateTime.Today;
            var currentMonthWorkingDays = DateTime.DaysInMonth(today.Year, today.Month);
            var workingDays = 0;
            var workingHoursPerDay = 8;

            for (int i = 1; i <= currentMonthWorkingDays; i++)
            {
                var currentDate = new DateTime(today.Year, today.Month, i);

                if (currentDate.DayOfWeek != DayOfWeek.Saturday && currentDate.DayOfWeek != DayOfWeek.Sunday)
                {
                    workingDays++;
                }
            }

            foreach (var employee in employees)
            {
                var salaryPerHour = (employee.Salary / workingDays) / workingHoursPerDay;
                employee.TotalAmount += employee.HoursOfWork * salaryPerHour;
            }
        }
    }
}

namespace DecoratorPattern.Models
{
    public class Employee
    {
        public Employee(string name, decimal salary, decimal hoursOfWork)
        {
            Name = name;
            Salary = salary;
            HoursOfWork = hoursOfWork;
        }

        public string Name { get; private set; }

        public decimal Salary { get; set; }

        public decimal TotalAmount { get; set; }

        public decimal HoursOfWork { get; set; }
    }
}

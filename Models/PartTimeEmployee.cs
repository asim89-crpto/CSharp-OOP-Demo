namespace CSharp_OOP_Demo.Models
{
    public class PartTimeEmployee : Employee
    {
        private int HoursWorked;
        private double HourlyRate;

        public PartTimeEmployee(int id, string name, int hoursWorked, double hourlyRate)
            : base(id, name)
        {
            HoursWorked = hoursWorked;
            HourlyRate = hourlyRate;
        }

        public override double CalculateSalary()
        {
            return HoursWorked * HourlyRate;
        }
    }
}
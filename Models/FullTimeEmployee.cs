namespace CSharp_OOP_Demo.Models
{
    public class FullTimeEmployee : Employee
    {
        private double BaseSalary;
        private double Bonus;

        public FullTimeEmployee(int id, string name, double baseSalary, double bonus)
            : base(id, name)
        {
            BaseSalary = baseSalary;
            Bonus = bonus;
        }

        public override double CalculateSalary()
        {
            return BaseSalary + Bonus;
        }
    }
}
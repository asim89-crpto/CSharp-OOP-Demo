using CSharp_OOP_Demo.Interfaces;

namespace CSharp_OOP_Demo.Models
{
    public abstract class Employee : ISalaryCalculator
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        protected Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public abstract double CalculateSalary();
    }
}
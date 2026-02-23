using CSharp_OOP_Demo.Models;

namespace CSharp_OOP_Demo.Services
{
    public class SalaryService
    {
        public double CalculateTotalPayroll(List<Employee> employees)
        {
            double total = 0;

            foreach (var employee in employees)
            {
                total += employee.CalculateSalary();
            }

            return total;
        }
    }
}
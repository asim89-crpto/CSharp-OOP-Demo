using CSharp_OOP_Demo.Models;
using CSharp_OOP_Demo.Services;

var employees = new List<Employee>
{
    new FullTimeEmployee(1, "Ali", 3000, 500),
    new PartTimeEmployee(2, "Asim", 20, 25)
};

foreach (var emp in employees)
{
    Console.WriteLine($"{emp.Name} salary = {emp.CalculateSalary()}");
}

var salaryService = new SalaryService();
double totalPayroll = salaryService.CalculateTotalPayroll(employees);

Console.WriteLine($"Total Payroll = {totalPayroll}");
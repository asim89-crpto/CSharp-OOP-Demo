
using System.Security.Cryptography.X509Certificates;
using System;
using System.Collections.Generic;
public class Employee
{
    // TODO 1: Make these fields private
    private int id;
    private string name;
    private double baseSalary;

    // TODO 2: Create a constructor to initialize all fields

    public Employee(int id, string name, double baseSalary)
    {
        this.id = id;
        this.name = name;
        this.baseSalary = baseSalary;
    }

    // TODO 3: Create public getters and setters (Encapsulation)




    public int Id
    {
        get { return id; }

        set { id = value; }
    }

    public string Name

    {

        get { return name; }

        set { name = value; }
    }

    public double BaseSalary


    {
        get { return baseSalary; }
        set { baseSalary = value; }
    }





    // TODO 4: Create a virtual method CalculateSalary()

    // TODO 4: Create a virtual method CalculateSalary()
    public virtual double CalculateSalary()
    {
        return baseSalary;
    }
}

// It should return baseSalary





public class FullTimeEmployee : Employee
{
    private double bonus;

    // TODO 5: Constructor
    public FullTimeEmployee(int id, string name, double baseSalary, double bonus)
        : base(id, name, baseSalary)
    {
        this.bonus = bonus;
    }

    // TODO 6: Override CalculateSalary()
    public override double CalculateSalary()
    {
        return base.CalculateSalary() + bonus;
    }
}




public class PartTimeEmployee : Employee
{
    private int hoursWorked;
    private double hourlyRate;

    // TODO 7: Constructor
    public PartTimeEmployee(int id, string name, int hoursWorked, double hourlyRate)
        : base(id, name, 0) // baseSalary is not used for part-time
    {
        this.hoursWorked = hoursWorked;
        this.hourlyRate = hourlyRate;
    }

    // TODO 8: Override CalculateSalary()
    public override double CalculateSalary()
    {
        return hoursWorked * hourlyRate;
    }
}

// TODO 8: Override CalculateSalary()
// Salary = hoursWorked * hourlyRate






class Program
{
    static void Main(string[] args)
    {
        // TODO 9: Create employees (use correct constructors)
        FullTimeEmployee fe = new FullTimeEmployee(1, "Ali", 3000, 500);
        PartTimeEmployee pe = new PartTimeEmployee(2, "Asim", 20, 25);

        // TODO 10: Store both in List<Employee>
        List<Employee> employees = new List<Employee> { fe, pe };

        // TODO 11: Loop and print salary (polymorphism)
        foreach (Employee emp in employees)
        {
            Console.WriteLine($"{emp.Name} salary = {emp.CalculateSalary()}");
        }
    }
}
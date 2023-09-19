using EfProject.Application.Interfaces;
using EfProject.Domain.Models;
using EfProject.Domain.States;

namespace EfProject.Application.Services;

public class ReadEmployee : IReadEmployee
{
    public Employee ReadEmployeeForCreate(Employee employee)
    {
        Console.Write("Enter name: "); employee.Name = Console.ReadLine() ?? "";
        Console.Write("Enter salary: "); employee.Salary = int.Parse(Console.ReadLine() ?? "");
        Console.WriteLine("Level: ");
        Console.WriteLine("1.Junior");
        Console.WriteLine("2.Middle");
        Console.WriteLine("3.Senior");
        Console.Write("Choose an option: "); byte isA = byte.Parse(Console.ReadLine() ?? "");
        switch (isA)
        {
            case 1:
                employee.level = Level.Junior;
                break;
            case 2:
                employee.level = Level.Middle;
                break;
            case 3:
                employee.level = Level.Senior;
                break;
        }

        return employee;
    }
}

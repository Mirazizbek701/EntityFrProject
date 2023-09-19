using EfProject.Application.Services;
using EfProject.Domain.Models;
using EfProject.Infrastructure.Services;

namespace EfProject.Presentation.Mediators;

public class EmployeeMediator
{
    public static ReadEmployee? readEmployee;
    public static EmployeeService? empService;
    public EmployeeMediator()
    {
        readEmployee = new();
        empService = new();
    }

    public void Create()
    {
        Employee employee = new();
        empService?.CreateEmployee(employee);
        Console.ReadKey();
    }

    public void Delete()
    {
        IList<Employee> list = (IList<Employee>)GetAll();
        Console.Write("Enter Id of Employee to delete: ");
        byte id = byte.Parse(Console.ReadLine() ?? "");
        Employee? ById = list.FirstOrDefault(i => i.Id == id);
        if (ById != null) empService.DeleteEmployee(ById.Id);
        else Console.WriteLine($"{id} not exist");
        Console.ReadKey();
    }

    public IEnumerable<Employee> GetAll()
    {
        IEnumerable<Employee> list = empService.GetAll();
        foreach (Employee emp in list)
        {
            Console.WriteLine("---------");
            Console.WriteLine("Id: " + emp.Id);
            Console.WriteLine("Name: " +emp.Name);
            Console.WriteLine("Salary: " + emp.Salary);
            Console.WriteLine("Level: " + emp.level);
        }
        return list;
    }

    public void GetById()
    {
        IList<Employee> list = (IList<Employee>)GetAll();
        Console.Clear();
        Console.Write("Enter Id of employee you want to see: ");
        int id = int.Parse(Console.ReadLine() ?? "");
        Employee? ById = list.FirstOrDefault(i => i.Id == id);
        if (ById != null) { Console.WriteLine(ById.ToString()); }
        else Console.Out.WriteLineAsync($"{id} do not exist");
        Console.ReadKey();
    }

    public void Update()
    {
        IList<Employee> list = (IList<Employee>)GetAll();
        Console.Write("Enter Id of employee you want to update: ");
        int id = int.Parse(Console.ReadLine() ?? "");
        Employee? ById = list.FirstOrDefault(i => i.Id == id);
        empService.UpdateEmployee(ById);
    }

}

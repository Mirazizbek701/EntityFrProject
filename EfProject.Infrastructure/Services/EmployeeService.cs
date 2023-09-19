using EfProject.Application.Interfaces;
using EfProject.Application.Services;
using EfProject.Domain.Models;
using EfProject.Infrastructure.DbConfiguration;

namespace EfProject.Infrastructure.Services;

public class EmployeeService : IEmployeeService
{
    private ReadEmployee readEmployee = new();
    private static AppDbContext dbContext = new();
    public Employee CreateEmployee(Employee employee)
    {
        Employee createdEmployee = readEmployee.ReadEmployeeForCreate(employee);
        dbContext.employees.Add(createdEmployee);
        dbContext.SaveChanges();
        return createdEmployee;
    }

    public void DeleteEmployee(int employeeId)
    {
        dbContext.employees.Remove(GetById(employeeId));
        dbContext.SaveChanges();
    }

    public IEnumerable<Employee> GetAll()
    {
        return dbContext.employees.ToList();
    }

    public Employee? GetById(int employeeId)
    {
        return dbContext.employees.FirstOrDefault(x => x.Id == employeeId);
    }


    public Employee UpdateEmployee(Employee employee)
    {
        Employee? EntityEmployee  = GetById(employee.Id);
        Employee updatedEmployee = readEmployee.ReadEmployeeForCreate(EntityEmployee);
        dbContext.employees.Update(updatedEmployee);
        dbContext.SaveChanges();
        return updatedEmployee;
    }
}

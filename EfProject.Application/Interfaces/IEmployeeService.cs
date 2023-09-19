using EfProject.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfProject.Application.Interfaces;

public interface IEmployeeService
{
    Employee CreateEmployee(Employee employee);
    Employee UpdateEmployee(Employee employee);
    void DeleteEmployee(int employeeId);
    IEnumerable<Employee> GetAll();
    Employee GetById(int employeeId);
}

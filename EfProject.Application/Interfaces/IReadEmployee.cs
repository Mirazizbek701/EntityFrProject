using EfProject.Domain.Models;

namespace EfProject.Application.Interfaces;

public interface IReadEmployee
{
    public Employee ReadEmployeeForCreate(Employee obj);
}

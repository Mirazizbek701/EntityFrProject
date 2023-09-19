using EfProject.Domain.Models;

namespace EfProject.Application.Interfaces;

public interface IReadProject
{
    public Project ReadProjectForCreate(Project obj);
}

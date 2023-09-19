using EfProject.Domain.Models;

namespace EfProject.Application.Interfaces;

public interface IProjectService
{
    Project CreateProject(Project project);
    Project UpdateProject(Project project);
    void DeleteProject(int projectId);
    IEnumerable<Project> GetAll();
    Project GetById(int projectId);
}

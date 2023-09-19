using EfProject.Application.Interfaces;
using EfProject.Application.Services;
using EfProject.Domain.Models;
using EfProject.Infrastructure.DbConfiguration;

namespace EfProject.Infrastructure.Services;

public class ProjectService : IProjectService
{
    private ReadProject readProject = new();
    private static AppDbContext dbContext = new();

    public Project CreateProject(Project project)
    {
        Project createdProject = readProject.ReadProjectForCreate(project);
        dbContext.projects.Add(createdProject);
        dbContext.SaveChanges();
        return createdProject;
    }

    public Project UpdateProject(Project project)
    {
        Project? EntityProject = GetById(project.project_id);
        Project updatedProject = readProject.ReadProjectForCreate(EntityProject);
        dbContext.projects.Update(updatedProject);
        dbContext.SaveChanges();
        return updatedProject;
    }

    public void DeleteProject(int projectId)
    {
        dbContext.projects.Remove(GetById(projectId));
        dbContext.SaveChanges();
    }

    public IEnumerable<Project> GetAll()
    {
        return dbContext.projects.ToList();
    }

    public Project? GetById(int projectId)
    {
        return dbContext.projects.FirstOrDefault(x => x.project_id == projectId);
    }
}

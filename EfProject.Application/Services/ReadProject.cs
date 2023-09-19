using EfProject.Application.Interfaces;
using EfProject.Domain.Models;

namespace EfProject.Application.Services;

public class ReadProject : IReadProject
{
    public Project ReadProjectForCreate(Project project)
    {
        Console.Write("Enter project name: "); project.project_name = Console.ReadLine() ?? "";
        project.isCreated = DateTime.Now.ToShortDateString();
        Console.Write("Enter employee id: "); project.employeeId = int.Parse(Console.ReadLine() ?? "");
        return project;
    }
}

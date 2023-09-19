using EfProject.Application.Services;
using EfProject.Domain.Models;
using EfProject.Infrastructure.Services;

namespace EfProject.Presentation.Mediators;

public class ProjectMediator
{
    public static ReadProject? readProject;
    public static ProjectService? prjService;
    public ProjectMediator()
    {
        readProject = new();
        prjService = new();
    }

    public void Create()
    {
        Project project = new();
        prjService.CreateProject(project);
        Console.ReadKey();
    }

    public void Delete()
    {
        prjService.GetAll();
        IList<Project> list = (IList<Project>)prjService.GetAll();
        Console.WriteLine("Enter Id of Project to delete: ");
        byte id = byte.Parse(Console.ReadLine() ?? "");
        Project? ById = list.FirstOrDefault(i => i.project_id == id);
        if (ById != null) prjService.DeleteProject(ById.project_id);
        else Console.WriteLine($"{id} do not exist");
        Console.ReadKey();
    }

    public IEnumerable<Project> GetAll()
    {
        IEnumerable<Project> list = prjService.GetAll();
        foreach (Project prj in list)
        {
            Console.WriteLine("---------");
            Console.WriteLine("Id: " + prj.project_id);
            Console.WriteLine("Name: " + prj.project_name);
            Console.WriteLine("Date Created: " + prj.isCreated);
            Console.WriteLine("Created By Employee: " + prj.employeeId); 
        }
        Console.ReadKey();
        return list;
    }

    public void GetById()
    {
        IList<Project> list = (IList<Project>)GetAll();
        Console.Clear();
        Console.WriteLine("Enter Id of project you want to see: ");
        int id = int.Parse(Console.ReadLine() ?? "");
        Project? ById = list.FirstOrDefault(i => i.project_id == id);
        if (ById != null) { Console.WriteLine(ById.ToString()); }
        else Console.Out.WriteLineAsync($"{id} do not exist");
        Console.ReadKey();
    }

    public void Update()
    {
        IList<Project> list = (IList<Project>)GetAll();
        Console.WriteLine("Enter Id of project you want to update: ");
        int id = int.Parse(Console.ReadLine() ?? "");
        Project? ById = list.FirstOrDefault(i => i.project_id == id);
        prjService.UpdateProject(ById);
    }
}

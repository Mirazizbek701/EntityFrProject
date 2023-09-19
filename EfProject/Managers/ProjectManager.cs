using EfProject.Presentation.Mediators;

namespace EfProject.Presentation.Managers;

public class ProjectManager
{
    public static void ProjectManagerStaff()
    {
        ProjectMediator prjMediator = new();
        while (true)
        {
            Console.Clear();
            Console.WriteLine("----Project_Manager----");
            Console.WriteLine("1.Create Project");
            Console.WriteLine("2.Get All Projects");
            Console.WriteLine("3.Update Project");
            Console.WriteLine("4.Delete Project");
            Console.WriteLine("5.Get Project By Id");
            Console.WriteLine("6.Exit");
            Console.Write("Choose an option: "); byte isA = byte.Parse(Console.ReadLine() ?? "");

            switch (isA)
            {
                case 1:
                    prjMediator.Create();
                    break; 
                case 2:
                    prjMediator.GetAll();
                    break;
                case 3:
                    prjMediator.Update();
                    break;
                case 4:
                    prjMediator.Delete();
                    break;
                case 5:
                    prjMediator.GetById();
                    break;
                case 6:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Wrong option, try again!!!");
                    Thread.Sleep(700);
                    break;
            }
        }
    }
}

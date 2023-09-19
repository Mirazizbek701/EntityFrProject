namespace EfProject.Presentation.Managers;

public class AllManager
{
    public static void AllStaffManager()
    {
        while (true)
        {
            Console.WriteLine("----All_Manager----");
            Console.WriteLine("1.Employee Staff");
            Console.WriteLine("2.Project Staff");
            Console.WriteLine("3.Exit");
            Console.Write("Choose an option: "); byte isA = byte.Parse(Console.ReadLine() ?? "");

            switch (isA)
            {
                case 1:
                    EmployeeManager.EmployeeManagerStaff();
                    break;
                case 2:
                    ProjectManager.ProjectManagerStaff();
                    break;
                case 3:

                default:
                    Console.WriteLine("Wrong option, try again!!!");
                    Thread.Sleep(700);
                    break;
            }

        }
    }
}

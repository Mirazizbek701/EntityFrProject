using EfProject.Presentation.Mediators;

namespace EfProject.Presentation.Managers;

public class EmployeeManager
{
    public static void EmployeeManagerStaff()
    {
        EmployeeMediator employeeMediator = new EmployeeMediator();
        while (true)
        {
            Console.Clear();
            Console.WriteLine("----Employee_Manager----");
            Console.WriteLine("1.Create");
            Console.WriteLine("2.Get All Employees");
            Console.WriteLine("3.Update Employee");
            Console.WriteLine("4.Delete Employee");
            Console.WriteLine("5.Get Employee By Id");
            Console.WriteLine("6.Exit");
            Console.Write("Choose an option: "); byte isA = byte.Parse(Console.ReadLine() ?? "");

            switch (isA)
            {
                case 1:
                    employeeMediator.Create(); break;
                case 2:
                    employeeMediator.GetAll(); break;
                case 3:
                    employeeMediator.Update(); break;
                case 4:
                    employeeMediator.Delete(); break;
                case 5:
                    employeeMediator.GetById(); break;
                case 6:
                    Environment.Exit(0); break;
                default:
                    Console.WriteLine("Wrong option, try again!!!");
                    Thread.Sleep(700);
                    break;
            }
            Console.ReadKey();
        }
    }
}

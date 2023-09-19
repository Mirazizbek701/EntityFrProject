using EfProject.Presentation.StartUp;

namespace EfProject;

internal class Program
{
    static void Main(string[] args)
    {
        try
        {
        StartUp.Start();
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
}
using System.Security.AccessControl;

namespace DirectoriesTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string currDirectory = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\..\_Directories"));



            Console.WriteLine(
                    currDirectory                
                );


        }
    }
}
 
    


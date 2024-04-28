using System.Security.AccessControl;

namespace DirectoriesTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string currDirectory = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\..\_Directories"));

            string[] dirs = Directory.GetDirectories(currDirectory);

            //foreach (string dir in dirs)
            //{
            //    //string dirTreated = dir.Remove(0, dir.LastIndexOf(@"\")+1);
            //    Console.WriteLine(dir);
            //}
            string[] files = Directory.GetFiles(currDirectory);

            foreach (string file in files)
            {
                Console.WriteLine(file);
            }


        }
    }
}
 
    


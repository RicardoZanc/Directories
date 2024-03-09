using System.Security.AccessControl;

namespace DirectoriesTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string currDirectory = "C:\\Users\\ricar\\OneDrive\\Documentos\\Estudo\\C#\\WebApplication1\\_Directories";

            string[] direcs = Directory.GetDirectories(currDirectory);



            foreach (string d in direcs)
            {
                Console.WriteLine(d.Remove(0, d.LastIndexOf("\\")+1));
            }


        }
    }
}
 
    


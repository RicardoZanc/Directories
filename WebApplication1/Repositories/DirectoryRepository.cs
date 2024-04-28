using WebApplication1.Models;

namespace WebApplication1.Repositories
{
    public class DirectoryRepository
    {
        string currDirectory = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\_Directories"));

        public DirectoryModel AddDirectory(DirectoryModel directoryModel)
        {
            Directory.CreateDirectory($"{currDirectory}\\{directoryModel.Name}");
            return directoryModel;
        }

        public string[] GetDirectories()
        {
            string[] directories = Directory.GetDirectories(currDirectory);
            string[] directoriesTreated = new string[directories.Length];

            for(int i =0; i < directories.Length; i++)
            {
                directoriesTreated[i] = directories[i].Remove(0, directories[i].LastIndexOf(@"\") + 1);
            }

            return directoriesTreated;
        }
    }
}

using WebApplication1.Models;

namespace WebApplication1.Repositories
{
    public class ArchiveRepository
    {
        string currDirectory = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\_Directories"));

        public ArchiveModel AddArchive(ArchiveModel archiveModel)
        {
            if(archiveModel.ArchiveType == ArchiveModel._ArchiveType.Folder)
            {
               Directory.CreateDirectory($@"{currDirectory}\{archiveModel.Name}");
               return archiveModel;
            }
            else if (archiveModel.ArchiveType == ArchiveModel._ArchiveType.File)
            {
                File.Create($@"{currDirectory}\{archiveModel.Name}.txt");
               return archiveModel;
            }
            else
            {
                return archiveModel;
            }
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

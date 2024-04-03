using WebApplication1.Models;

namespace WebApplication1.Repositories
{
    public class DirectoryRepository
    {
        public DirectoryModel AddDirectory(DirectoryModel directoryModel)
        {
            Directory.CreateDirectory($"C:\\Users\\ricar\\OneDrive\\Documentos\\Estudo\\C#\\WebApplication1\\_Directories\\{directoryModel.Name}");
            return directoryModel;
        }

        public string GetDirectories()
        {
            return Directory.GetCurrentDirectory();

        }
    }
}

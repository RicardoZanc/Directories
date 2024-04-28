namespace WebApplication1.Models
{
    public abstract class ArchiveModel
    {
        public enum ArchiveType {Folder, File}
        public string Name { get; set; }
        public string AbsolutePath { get; set; }
    }
}

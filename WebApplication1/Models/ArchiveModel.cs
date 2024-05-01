namespace WebApplication1.Models
{
    public abstract class ArchiveModel
    {
        public enum _ArchiveType {Folder, File}
        public string Name { get; set; }
        public string AbsolutePath { get; set; }
        public _ArchiveType ArchiveType { get; set; }
    }
}

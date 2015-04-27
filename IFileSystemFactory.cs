namespace Dargon.FileSystems {
   public interface IFileSystemFactory {
      IFileSystem CreateFromDirectory(string path);
   }
}

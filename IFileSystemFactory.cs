namespace Dargon.FileSystem {
   public interface IFileSystemFactory {
      IFileSystem CreateFromDirectory(string path);
   }
}

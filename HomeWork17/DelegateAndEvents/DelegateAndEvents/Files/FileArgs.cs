
namespace DelegateAndEvents.Files
{
    public class FileArgs : EventArgs
    {
        public string fileName;
        public FileArgs(string argFileName) => fileName = argFileName;
    }
}

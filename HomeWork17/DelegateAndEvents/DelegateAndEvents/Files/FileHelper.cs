
namespace DelegateAndEvents.Files
{
    public static class FileHelper
    {
        public static void FileFoundHandler(object sender, EventArgs args) => Console.WriteLine((args as FileArgs)?.fileName);
    }
}

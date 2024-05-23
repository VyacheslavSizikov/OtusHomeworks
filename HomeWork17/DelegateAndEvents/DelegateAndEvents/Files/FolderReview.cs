namespace DelegateAndEvents.Files
{
    public class FolderReview
    {
        public event EventHandler<FileArgs>? FileFound;
        private readonly string _path;
        public FolderReview(string path) => _path = path;
        //Флаг отмены операции
        public bool cancelOpertion = false;

        public void StartSearch()
        {

            var filesinDir = Directory.EnumerateFiles(_path).ToList();
            if (filesinDir.Any())
            {
                foreach (var file in filesinDir)
                {
                    //Реализация отмены поиска файлов
                    if (cancelOpertion == true)
                        return;

                    FileFoundNotification(file);
                }
            }
        }
        
        void FileFoundNotification(string file) => FileFound?.Invoke(this, new FileArgs(file));
    }

    

    
}

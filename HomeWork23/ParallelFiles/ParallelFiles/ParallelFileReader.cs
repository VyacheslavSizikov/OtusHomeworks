using System.Diagnostics;

namespace ParallelFiles
{
    public class ParallelFileReader
    {
        public delegate void FileSpacesCountedEvent(ParallelFileReader sender, FileSpaceCountedEventArgs e);
        public event FileSpacesCountedEvent? FileSpaceCountedEventHandler;

        //Чтение пробелов в файле
        private async Task CountFileSpaces(string filePath)
        {
            long spacesCnt = 0;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            using (var sr = new StreamReader(filePath))
            {
                foreach (var item in sr.ReadToEnd())
                {
                    if (item == ' ') spacesCnt++;
                }
            }
            sw.Stop();

            FileSpaceCountedEventHandler?.Invoke(this, new FileSpaceCountedEventArgs { FilePath = filePath, SpacesCount = spacesCnt, ProcessingTime = sw.Elapsed });
        }


        //Чтение пробелов в файлах внутри папки
        public async Task ReadAllFromDirectory(string folderPath)
        {
            if (Directory.Exists(folderPath))
            {
                await ReadFromFilePathList(Directory.GetFiles(folderPath).ToList());
            }
            else
            {
                throw new DirectoryNotFoundException($"Ошибка! Не удалось найти путь {folderPath}.");
            }
        }

        //Параллельное выполнение задач подсчета
        public async Task ReadFromFilePathList(List<string> filePathList)
        {
            List<Task> tasks = new List<Task>();
            foreach (string filePath in filePathList)
            {
                if (File.Exists(filePath))
                {
                    tasks.Add(CountFileSpaces(filePath));
                }
                else
                {
                    throw new FileNotFoundException($"Ошибка! Не удалось найти путь {filePath}.");
                }
            }
            await Task.WhenAll(tasks);
        }

        
    }
    
}

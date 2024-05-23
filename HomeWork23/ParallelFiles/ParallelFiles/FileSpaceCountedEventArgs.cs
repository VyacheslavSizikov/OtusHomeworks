namespace ParallelFiles
{
    public class FileSpaceCountedEventArgs : EventArgs
    {
        public string FilePath { get; set; }
        public long SpacesCount { get; set; }
        public TimeSpan ProcessingTime { get; set; }
    }
}

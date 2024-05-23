using ParallelFiles;
using System.Diagnostics;

ParallelFileReader reader = new ParallelFileReader();
reader.FileSpaceCountedEventHandler += OutputcountingResult;

Stopwatch sw = new Stopwatch();
sw.Start();
await reader.ReadAllFromDirectory("SourceFiles");
sw.Stop();
Console.WriteLine($"Время выполнения кода: {sw.Elapsed}");

static void OutputcountingResult(ParallelFileReader sender, FileSpaceCountedEventArgs e)
{
    Console.WriteLine($"Файл: {Path.GetFileName(e.FilePath)}, пробелов: {e.SpacesCount}, время обработки: {e.ProcessingTime}");
}

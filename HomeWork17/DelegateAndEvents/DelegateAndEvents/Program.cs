using DelegateAndEvents;
using DelegateAndEvents.Files;

Console.Clear();

//Поиск максимального элемента коллекции.
var elementsList = new List<CollectionElement> { new CollectionElement(500), new CollectionElement(200), new CollectionElement(100), new CollectionElement(800), new CollectionElement(100), };
var maCollectionElement = elementsList.GetMaxElement(CollectionElement.GetParameter);
Console.WriteLine($"Исходная коллекция - {String.Join(',', elementsList)}");
Console.WriteLine($"Максимальное значения в коллекции - {maCollectionElement};\n");


//Каталог файлов и событие при нахождении каждого файла.
var location = typeof(Program).Assembly.Location;
var path = Path.GetDirectoryName(location);
var filesInFolder = new FolderReview(path!);

filesInFolder.FileFound += FileHelper.FileFoundHandler!;
Console.WriteLine("Файлы в папке: ");
Task.Run(new Action(() => filesInFolder.StartSearch()));

Console.WriteLine("Для отмены поиска нажмите c...");
var key = Console.ReadKey().KeyChar;
if (key == 'c')
{
    Console.WriteLine();
    filesInFolder.cancelOpertion = true;
}

filesInFolder.FileFound -= FileHelper.FileFoundHandler!;

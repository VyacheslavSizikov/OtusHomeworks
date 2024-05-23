using ParallelCalculating;

int arrLength1 = 100_000;
int arrLength2 = 1_000_000;
int arrLength3 = 10_000_000;
int threadsCount = 10;

Console.Clear();
Console.WriteLine($"Измерение для элементов: - {arrLength1}");
var elementsArray = ArraysGenerated.GenerateIntArray(arrLength1);
Calculation.RegularSum(elementsArray);
Calculation.ThreadSum(elementsArray, threadsCount);
Calculation.ParallelSum(elementsArray);
Console.WriteLine();

Console.WriteLine($"Измерение для элементов: {arrLength2}");
elementsArray = ArraysGenerated.GenerateIntArray(arrLength2);
Calculation.RegularSum(elementsArray);
Calculation.ThreadSum(elementsArray, threadsCount);
Calculation.ParallelSum(elementsArray);
Console.WriteLine();

Console.WriteLine($"Измерение для элементов: {arrLength3}");
elementsArray = ArraysGenerated.GenerateIntArray(arrLength3);
Calculation.RegularSum(elementsArray);
Calculation.ThreadSum(elementsArray, threadsCount);
Calculation.ParallelSum(elementsArray);
Console.WriteLine();



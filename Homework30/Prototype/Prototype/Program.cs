
// Демонстрация клонирования
// Создание объектов
using Prototype;

Animal animal1 = new Mammal("Fluffy", 5, true);
Animal animal2 = new Bird("Tweety", 3, true);
Animal animal3 = new Reptile("Scaly", 7, true);

// Клонирование объектов
Animal clonedAnimal1 = animal1.Clone();
Animal clonedAnimal2 = animal2.Clone();
Animal clonedAnimal3 = animal3.Clone();

// Вывод результатов
Console.WriteLine($"Original animal 1: {animal1.Name}, {animal1.Age}, {((Mammal)animal1).IsFurry}");
Console.WriteLine($"Cloned animal 1: {clonedAnimal1.Name}, {clonedAnimal1.Age}, {((Mammal)clonedAnimal1).IsFurry}");

Console.WriteLine($"Original animal 2: {animal2.Name}, {animal2.Age}, {((Bird)animal2).CanFly}");
Console.WriteLine($"Cloned animal 2: {clonedAnimal2.Name}, {clonedAnimal2.Age}, {((Bird)clonedAnimal2).CanFly}");

Console.WriteLine($"Original animal 3: {animal3.Name}, {animal3.Age}, {((Reptile)animal3).IsColdBlooded}");
Console.WriteLine($"Cloned animal 3: {clonedAnimal3.Name}, {clonedAnimal3.Age}, {((Reptile)clonedAnimal3).IsColdBlooded}");

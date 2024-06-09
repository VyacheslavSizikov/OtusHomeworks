
namespace Prototype
{
    // Базовый абстрактный класс
    public abstract class Animal : IMyCloneable<Animal>, ICloneable
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual Animal Clone()
        {
            return (Animal)this.MemberwiseClone();
        }

        object ICloneable.Clone()
        {
            return this.Clone();
        }
    }
}


namespace Prototype
{
    // Класс Mammal, наследующий от Animal
    public class Mammal : Animal
    {
        public bool IsFurry { get; set; }

        public Mammal(string name, int age, bool isFurry) : base(name, age)
        {
            IsFurry = isFurry;
        }

        public override Animal Clone()
        {
            return new Mammal(Name, Age, IsFurry);
        }
    }
}



namespace Prototype
{
    // Класс Bird, наследующий от Animal
    public class Bird : Animal
    {
        public bool CanFly { get; set; }

        public Bird(string name, int age, bool canFly) : base(name, age)
        {
            CanFly = canFly;
        }

        public override Animal Clone()
        {
            return new Bird(Name, Age, CanFly);
        }
    }

}

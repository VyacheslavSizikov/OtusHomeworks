

namespace Prototype
{
    // Класс Reptile, наследующий от Animal
    public class Reptile : Animal
    {
        public bool IsColdBlooded { get; set; }

        public Reptile(string name, int age, bool isColdBlooded) : base(name, age)
        {
            IsColdBlooded = isColdBlooded;
        }

        public override Animal Clone()
        {
            return new Reptile(Name, Age, IsColdBlooded);
        }
    }
}

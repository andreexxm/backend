using System;
namespace Exercise.Entities
{
    public class Cat : Animal
    {
        public bool IsLazy { get; set; }

        public void Meow()
        {
            Console.WriteLine("MEOW MEWO");
        }

        public Cat()
        {
        }

        public Cat(string name, int age, string color, bool islazy)
            : base(name, age, color)
        {
            IsLazy = islazy;
        }

        public override void Print()
        {
            Console.WriteLine($"This is the cat {Name}, it's {Age} years old, its color is {Color}, and it's {IsLazy}");
        }
    }
}

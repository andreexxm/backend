using System;
namespace Exercise.Entities
{
    public class Bird : Animal
    {
        public bool IsWild { get; set; }

        public Bird()
        {
        }

        public Bird(string name, int age, string color, bool iswild)
            : base(name, age, color)
        {
            IsWild = iswild;
        }

        public override void Print()
        {
            Console.WriteLine($"This is the cat {Name}, it's {Age} years old, its color is {Color}, and it's {IsWild}");
        }

        public void FlySouth()
        {
            Console.WriteLine(IsWild ? "The bird has flown" : "The bird is domesticated");
        }
    }
}

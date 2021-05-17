using System;
namespace Exercise.Entities
{
    public class Dog : Animal
    {
        public string Race { get; set; }

        public Dog()
        {
        }

        public Dog (string name, int age, string color, string race)
            :base(name, age, color)
        {
            Race = race;
        }

        public void Bark()
        {
            Console.WriteLine("BARK BARK");
        }

        public override void Print()
        {
            Console.WriteLine($"This is {Name}, it's {Age} years old, its color is {Color}, and it's a {Race}");
        }

    }
}

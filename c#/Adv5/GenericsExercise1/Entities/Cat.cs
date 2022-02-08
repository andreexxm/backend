using System;
namespace GenericsExercise1.Entities
{
    public class Cat : Pet
    {
        public bool Lazy { get; set; }
        public int LivesLeft { get; set; }

        public override void PrintInfo()
        {
            Console.WriteLine($"The cat {Name} has {LivesLeft} lives left");
        }
    }
}

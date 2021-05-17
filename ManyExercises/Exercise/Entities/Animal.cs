using System;
namespace Exercise.Entities
{
    public abstract class Animal
    {


        public string Name { get; set; }
        public int Age { get; set; } // CUSTOM
        public string Color { get; set; }

        public Animal()
        {

        }
        public Animal(string name, int age, string color)
        {
            Name = name;
            Age = age;
            Color = color;
        }

        public abstract void Print();
    }
}

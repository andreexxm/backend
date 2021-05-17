using System;
using System.Collections.Generic;
using System.Linq;
using Exercise.Entities;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dog> dogs = new List<Dog>();
            dogs.Add(new Dog() { Name = "Monty", Age = 5, Color = "gray", Race = "pug" });
            dogs.Add(new Dog() { Name = "Pablo", Age = 17, Color = "red", Race = "doberman" });
            dogs.Add(new Dog() { Name = "Ushle", Age = 2, Color = "white", Race = "sharplaninec" });

            List<Cat> cats = new List<Cat>();
            cats.Add(new Cat() { Name = "Debby", Age = 12, Color = "blonde", IsLazy = true });
            cats.Add(new Cat() { Name = "Sophie", Age = 4, Color = "white", IsLazy = false });
            cats.Add(new Cat() { Name = "Ursula", Age = 22, Color = "black-ish", IsLazy = true });

            List<Bird> birds = new List<Bird>();
            birds.Add(new Bird() { Name = "Pevko", Age = 2, Color = "green", IsWild = false });
            birds.Add(new Bird() { Name = "Svirko", Age = 10, Color = "blue", IsWild = false });
            birds.Add(new Bird() { Name = "Trepko", Age = 12, Color = "red", IsWild = true });


            List<Dog> findAllPugs = dogs
                                .Where(x => x.Race == "pug")
                                .ToList();
            Console.WriteLine($"ALL THE PUGS ARE {findAllPugs}");


            Cat lastLazyCat = cats
                                .Where(x => x.IsLazy == true)
                                .LastOrDefault();
            Console.WriteLine($"The last lazy cat is {lastLazyCat}");

            List<Bird> youndAndWild = birds
                                        .Where(x => x.Age < 3)
                                        .Where(x => x.IsWild)
                                        .OrderBy(x => x.Name)
                                        .ToList();
            Console.WriteLine($"The young and wild are: {youndAndWild}");

        }
    }
}

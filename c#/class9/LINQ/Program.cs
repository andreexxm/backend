using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };

            // Select

            //var addOnetoNumbers = numbers
            //                        .Select((num, index) => num + 1)
            //                        .ToList();

            //foreach (int item in addOnetoNumbers)
            //{
            //    Console.WriteLine(item);
            //}

            //lazier way through loop through elements, tz skraten foreach

            //addOnetoNumbers.ForEach(num => Console.WriteLine(num));


            //Where
            List<int> greaterThanThree = numbers
                                   .Where(num => num >= 3)  // ocekuva boolean expression
                                   .ToList();
            //greaterThanThree.ForEach(num => Console.WriteLine(num));


            //Last
            int lastElement = numbers
                                .Last();
            //Console.Write(lastElement);



            List<Dog> dogs = new List<Dog>()
            {
                new Dog(){Name = "Sparky", Age = 2 },
            new Dog() { Name = "Bucky", Age = 1 },
            new Dog() { Name = "Chocho", Age = 3 },
            new Dog() { Name = "Helen", Age = 5 },
            new Dog() { Name = "Merk", Age = 2 },
            new Dog() { Name = "Billy", Age = 1 },
            new Dog() { Name = "Flo", Age = 4 },
            };

        var nameLongerThan3 = dogs
                                .Where(x => x.Name.Length > 3)
                                .ToList();
            //nameLongerThan3.ForEach(x => Console.WriteLine(x.Name));


            //all dogs with name starting with s
            List<Dog> nameStartsWithS = dogs
                                        .Where(x => x.Name.StartsWith("S"))
                                        .ToList();
            //nameStartsWithS.ForEach(x => Console.WriteLine(x.Name));


            Dog dogAge1NameB = dogs
                                .Where(x => x.Age == 1)
                                .Where(x => x.Name.StartsWith("B"))
                                .First();
            //Console.WriteLine(dogAge1NameB.Name);

            Dog dogAge1NameDefault = dogs
                                .Where(x => x.Age == 1)
                                .Where(x => x.Name.StartsWith("R"))
                                .FirstOrDefault(); //doesnt give an exzception, lets program keep running
            //Console.WriteLine(dogAge1NameDefault == null ? "No such dog" : dogAge1NameDefault.Name ); // damage control



            //all names of dogs
            List<string> namesOfDogs = dogs
                                .Select(x => x.Name)
                                .ToList();
            namesOfDogs.ForEach(x => Console.WriteLine(x));




        }
    }
}

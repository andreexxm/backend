using System;
using System.Collections.Generic;

namespace Collections // generic
{
    class Program
    {
        static void Main(string[] args)
        {
            #region List

            //List<string> sedcGroups = new List<string>() { "G1", "G2", "G3", "G4" };

            //    sedcGroups.Add("G5"); //adds 1 element

            //    foreach(string item in sedcGroups)
            //    {
            //        Console.Write($"{item} ");
            //    }



            //    sedcGroups.AddRange(new List<string>() { "G6", "G7", "G8" });  //adds multiple elements

            //    sedcGroups.Remove("G7");
            //    Console.WriteLine($"The list has {sedcGroups.Count} elements");

            //-----------------
            //    List<Car> cars = new List<Car>();
            //    cars.Add(new Car() { Model = "BMW" });
            //    cars.Add(new Car() { Model = "Tesla" });
            #endregion


            #region Dictionary
            //Dictionary<string, int> examPoints = new Dictionary<string, int>()
            //{
            //    {"John", 70 },
            //    {"Bob", 45 },
            //    {"Jack", 100 }
            //};

            //examPoints.Add("Kristina", 12);
            //examPoints.Add("Pane", 100); //key is unique and cannot be the same

            //foreach (var item in examPoints)
            //{
            //    Console.WriteLine($"The student {item.Key} has {item.Value} points.");
            //    Console.WriteLine(item.Value >= 50 ? "Passed" : "Failed");
            //    Console.WriteLine("------------");
            //}

            ////----------
            //Dictionary<string, Car> carsWithPlates = new Dictionary<string, Car>();
            //Car car01 = new Car() { Model = "Ford" };
            //Car car02 = new Car() { Model = "Opel" };


            //carsWithPlates.Add("SK1111AA", car01);
            //carsWithPlates.Add("PT1234CC", car01);

            //Console.WriteLine(carsWithPlates.ContainsKey("SK1111A")); //check if a record with that key is present in the dictionary (t/f)

            ////can access an element's Value with a given key
            //Car result = carsWithPlates["SK1111AA"];
            //Console.WriteLine(result.Model);
            #endregion

            #region Queue // FIFO principle

            //Queue<string> students = new Queue<string>();

            //students.Enqueue("Maxx");
            //students.Enqueue("Noos");
            //students.Enqueue("Abby");
            //students.Enqueue("Fede");

            //Console.WriteLine(students.Peek());

            //students.Dequeue();

            //Console.WriteLine(students.Peek());

            #endregion

            #region Stack // LIFO Priciple
            Stack<string> pancakes = new Stack<string>();

            pancakes.Push("pancake1");
            pancakes.Push("pancake2");
            pancakes.Push("pancake3");

            Console.WriteLine(pancakes.Peek());

            //remove an item
            pancakes.Pop(); // removes the one whose turn it is (pancake3)

            Console.WriteLine(pancakes.Peek());


            #endregion

        }
    }
}

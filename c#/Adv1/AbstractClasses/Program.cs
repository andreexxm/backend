using System;
using System.Collections.Generic;
using AbstractClasses.Entities;

namespace AbstractClasses
{
    class Program
    {
        //method definition
        public static void SayHi(string name) //method signature (access modifier, return type, name, parameters with type)
        {
            Console.WriteLine("$Hi { name} "); //method implementation (what it does) // can be overriden
        }
    
         static void Main(string[] args)
        {
            #region Instances
            Developer dev = new Developer("Bob Bobsky", 25, 82492783859385, 3, new List<string>() { "C#", "PHP" });
            Tester tester = new Tester("John Snow", 22, 57479284834924, 120);

            #endregion

            #region

            Console.WriteLine("The Tester");
            Console.WriteLine(tester.GetInfo());
            tester.Greet("Sanja");
            tester.TestFeature("Sending transaction to Blockchain");
            #endregion
        }

    }
}

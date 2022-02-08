using System;
using System.Collections.Generic;
using Exercise.Entities.Models;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {

            Student student01 = new Student(1, "Maxx", "hailmaxima", "sissyheh", new List<int>() { 28, 26, 30 });
            student01.PrintInfo();


            Teacher teacher1 = new Teacher(1, "Maxx", "hailmaxima", "sissyheh", new List<string>() { "chem", "bio"  });
            teacher1.PrintInfo();


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using Exercise.Entities.Interfaces;

namespace Exercise.Entities.Models
{
    public class Student : User, IStudent
    {

        public List<int> Grades { get; set; } = new List<int>();

        public Student()
        {
        }

        public Student(int id, string name, string username, string password, List<int> grades)
            :base(id, name, username, password)
        {
            Grades = grades;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Student: {Name} with username {Username} has average {Grades.Average()} grade.");
        }

        public void SkipsWorkshops()
        {
            Console.WriteLine ("i HATE WORKSHOPS AND Kristina is scary!");
        }
    }
}

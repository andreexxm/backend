using System;
using System.Collections.Generic;
using System.Linq;
using Exercise.Entities.Interfaces;

namespace Exercise.Entities.Models
{
    public class Teacher : User, ITeacher
    {
        public List<string> Subjects { get; set; } = new List<string>();

        
        public Teacher()
        {
        }

        public Teacher(int id, string name, string username, string password,  List<string> subjects)
            :base(id, name, username, password)
        {
            Subjects = subjects;
        }



        public void PrintSubjects()
        {
            Subjects.ForEach(x => Console.WriteLine(x));
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Teacher: {Name} with {Username} teaches {Subjects.Count()} subjects");
        }

        public void Teach()
        {
            Console.WriteLine("I teach ungrateful shits all day");
        }

        public void Grade()
        {
            Console.WriteLine("...and then they hate me");
        }
    }
}

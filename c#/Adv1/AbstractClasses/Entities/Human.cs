using System;
using AbstractClasses.Entities.Interfaces;

namespace AbstractClasses.Entities
{
    public abstract class Human : iHuman
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public long Phone { get; set; }


        public Human()
        {

        }

        public Human(string fullName, int age, long phone)
        {
            FullName = fullName;
            Age = age;
            Phone = phone;
        }

        //method with implementation
        public void Greet(String name)
        {
            Console.WriteLine($"Hey there {name}! My name is {FullName}");
        }


        //method without implementation
        //have to use the keyword abstract. If we dont, we have to add implementation
        public abstract string GetInfo();


    }
}

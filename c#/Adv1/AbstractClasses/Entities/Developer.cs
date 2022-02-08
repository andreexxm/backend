using System;
using System.Collections.Generic;
using AbstractClasses.Entities.Interfaces;

namespace AbstractClasses.Entities
{
    public class Developer : Human, IDeveloper
    {
        public int YearsExperience { get; set; }
        
        public List<string> ProgrammingLanguages { get; set; } = new List<string>();

        public Developer()
        {
        }

        public Developer(string fullName, int age, long phone, int yearsOfExperience, List<string> progLanguages)
            : base(fullName, age, phone)
        {
            YearsExperience = yearsOfExperience;
            ProgrammingLanguages = progLanguages;
        }

        public override string GetInfo()
        {
            return $"{FullName} ({Age}) - {YearsExperience} years of experience";
        }

        public void Code()
        {
            Console.WriteLine("tak tak tak ....");
        }

    }
}

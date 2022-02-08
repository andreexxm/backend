﻿using System;
namespace GenericsExercise1.Entities
{
    public class Dog : Pet
    {
        public bool GoodBoi { get; set; }
        public string FavoriteFood { get; set; }


        public override void PrintInfo()
        {
            Console.WriteLine($"Dog {Name} wants to eat {FavoriteFood}");
        }
    }
}

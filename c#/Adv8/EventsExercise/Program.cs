﻿using System;
using System.Linq;
using EventsExercise.Entities;

namespace EventsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Trainer kristina = new Trainer();

            //Student nikola = new Student("Nikola");
            //Student marija = new Student("Maxx");
            //Student jana = new Student("Jana");
            //Student ivan = new Student("Ivan");
            //Student gligor = new Student("Gligor");

            //kristina.EventHandler += nikola.Hear;
            //kristina.EventHandler += marija.Hear;
            //kristina.EventHandler += jana.Hear;
            //kristina.EventHandler += ivan.Hear;
            //kristina.EventHandler += gligor.Hear;

            //kristina.Announce("Gligor", 9);
            //kristina.Announce("Nekoj", 10);
            //kristina.Announce("Jana", 5);
            //kristina.Announce("Ivan", 5);
            //kristina.Announce("Pero", 7);
            //kristina.Announce("Nikola", 9);
            //kristina.Announce("Maxx", 10);

       
                int[] nums = { 3, 1, 2, 5, 4 };
                var ltAvg = from n in nums
                            let x = nums.Average()
                            where n < x
                            select n;
                Console.WriteLine("The average is" + nums.Average());
                Console.ReadLine();
            
        }
    }
    
}

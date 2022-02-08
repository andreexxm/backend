﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericsExercise1.Entities
{
    public class PetStore<T> where T : Pet
    {
        private List<T> DB { get; set; }

        public PetStore()
        {
            DB = new List<T>();
        }

        public void Insert(T item)
        {
            DB.Add(item);
            Console.WriteLine("Item added to DB!");
        }

        public void PrintPets()
        {
            foreach(T item in DB)
            {
                item.PrintInfo();
            }
        }

        public void BuyPet (string name)
        {
            T pet = DB.FirstOrDefault(x => x.Name == name);
            if (pet == null)
            {
                Console.WriteLine("No such pet");
                return;
            }
            DB.Remove(pet);
            Console.WriteLine("Congrats, you got your pet");
        }
    }
}

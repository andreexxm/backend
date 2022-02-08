using System;
using GenericsExercise1.Entities;

namespace GenericsExercise1
{
    class Program
    {
        public static PetStore<Dog> dogStore = new PetStore<Dog>();
        public static PetStore<Cat> catStore = new PetStore<Cat>();
        public static PetStore<Fish> FISHStore = new PetStore<Fish>();


        static void Main(string[] args)
        {
            dogStore.Insert(new Dog() { Name = "Sharko", Age = 8, Type = "Pinch", GoodBoi = false, FavoriteFood = "salad" });
            dogStore.Insert(new Dog() { Name = "Sparky", Age = 2, Type = "Labrador", GoodBoi = true, FavoriteFood = "chicken" });

            dogStore.PrintPets();
            Console.WriteLine("Buying shaeko");
            dogStore.BuyPet("Sharko");
            Console.WriteLine("Buying shaeko");
            dogStore.BuyPet("Sparky");
            dogStore.PrintPets();
        }
    }
}

using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            dog dog01 = new dog();

            Console.WriteLine("Entr a name:");
            dog01.Name = Console.ReadLine();

            Console.WriteLine("Entr a breed:");
            dog01.Breed = Console.ReadLine();

            Console.WriteLine("Entr a color:");
            dog01.Color = Console.ReadLine();

            Console.WriteLine("Enter one of the following activities:");
            Console.WriteLine("1. Eat, 2. Play, 3.ChaseTail");

            int userChoice = int.Parse(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    Console.WriteLine(dog01.Eat());
                    break;
                case 2:
                    Console.WriteLine(dog01.Play());
                    break;
                case 3:
                    Console.WriteLine(dog01.ChaseTail());
                    break;
                default:
                    Console.WriteLine("Invalid Number");
                    break;
            }

            Console.ReadLine();
        }
    }
}

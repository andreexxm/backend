using System;

namespace console.app
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1

            double firstDouble = 28743.33;
            double secondDouble = 8472.1;
            double divisionDouble = firstDouble / secondDouble;

            int firstInteger = 34234;
            int secondInteger = 587;
            int divisionInteger = firstInteger / secondInteger;

            Console.WriteLine(divisionDouble);
            Console.WriteLine(divisionInteger);


            //Exercise 2

            string ourString = "Filippo";
            string ourString2 = "I love uuuuuu";

            string sumStrings = ourString + " " + ourString2;
            Console.WriteLine(sumStrings);


            string numString = "9";
            string numString2 = "18";

            string sumNumStrings = numString + numString2;
            Console.WriteLine(sumNumStrings.GetType()); // u can check the type with .gettype method





            Console.ReadLine();

        }
    }
}

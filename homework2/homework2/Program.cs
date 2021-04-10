using System;

namespace homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1

            //int[] intArray = new int[5];
            //int[] evenNumbers = new int[0];

            //for(int i=0; i<=intArray.Length; i++)
            //{
            //    intArray[i] = int.Parse(Console.ReadLine());
            //    if (intArray[i] % 2 == 0)
            //    {
            //        Array.Resize(ref evenNumbers, (evenNumbers.Length + 1));
            //        evenNumbers[evenNumbers.Length - 1] = intArray[i];
            //    }
            //}

            //Console.WriteLine(intArray);
            //Console.WriteLine(evenNumbers);

            //Console.ReadLine();


            //int[] intArray = new int[5];
            //int evenSum = 0;

            //for (int i = 0; i <= intArray.Length; i++)
            //{
            //    Console.WriteLine("Enter a number");

            //    bool parseSuccess = int.TryParse(Console.ReadLine(), out intArray[i]);
            //    if (parseSuccess)
            //    {
            //        if (intArray[i] % 2 == 0)
            //        {
            //            evenSum += intArray[i];
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Please restart the application and try again");
            //    }
            //}

            //Console.WriteLine(intArray);
            //Console.WriteLine(evenSum);

            //Console.ReadLine();

            #endregion


            #region Task2

            string[] studentsG1 = { "Maxx", "Flo", "Alessia", "Arantxa", "Berta" };
            string[] studentsG2 = { "Andrea", "Menci", "Cousin1", "Cousin2", "Roomates" };

            Console.WriteLine("Please write either 1 or 2");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine(studentsG1);
                case "2":
                    Console.WriteLine(studentsG2);
                default:
                    Console.WriteLine("Please enter either 1 or 2");

            }



            #endregion
        }
    }
}

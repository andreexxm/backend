using System;

namespace class3
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Exercise 1
            //Console.WriteLine("Enter a number");
            //int input1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Output");
            //for (int i = 1; i <= input1; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("------------");

            //Console.WriteLine("Enter another number");
            //int input2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Output again");
            //for (int i = input2; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region Exercise 2

            //Console.WriteLine("Enter a number");
            //int input1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Even numbers");

            //for (int i = 2; i <= input1 ; i+=2)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("Odd numbers");

            //for (int i = 1; i <= input1; i += 2)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region Exercise 3

            //Console.WriteLine("Enter a number");
            //int input1 = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= input1; i++)
            //{
            //    if (i % 3 == 0 || i % 7 == 0) continue;
            //    if (i == 100)
            //    {
            //        Console.WriteLine("The limint is reached!");
            //        break;
            //    }
            //    Console.WriteLine(i);
            //}

            #endregion

            #region Exercise5

            Console.WriteLine("Write 5 elements in the array");

            int[] userArray = new int[5];
            int sumNumbers = 0;

            for (int i = 0; i < userArray.Length; i++)
            {
                Console.WriteLine("Enter number: ");
                int userNumber = int.Parse(Console.ReadLine());
                userArray[i] = userNumber;
                sumNumbers += userNumber;
            }

            Console.WriteLine("Sum of all numbers is " + sumNumbers);



            #endregion

        }
    }
}

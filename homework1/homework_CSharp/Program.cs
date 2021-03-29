using System;

namespace homework_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            //         Console.WriteLine("Please enter your first number, and click Enter");
            //// going for functionality, not UX
            //string input1 = Console.ReadLine();

            //Console.WriteLine("Please enter your second number and click Enter");
            //string input2 = Console.ReadLine();

            //int number1;
            //bool success1 = int.TryParse(input1, out number1);


            //int number2;
            //bool success2 = int.TryParse(input2, out number2);



            //if (success1 && success2)
            //{
            //	Console.WriteLine("Please enter your desired operator and click Enter");
            //	string theOperator = Console.ReadLine();


            //	int RealCalculator = 0;   // you suggested we always do this
            //	switch (theOperator)
            //	{
            //		case "+":
            //			RealCalculator = number1 + number2;
            //			Console.WriteLine("Your result is " + RealCalculator);
            //			break;
            //		case "-":
            //			RealCalculator = number1 - number2;
            //			Console.WriteLine("Your result is " + RealCalculator);
            //			break;
            //		case "*":
            //			RealCalculator = number1 * number2;
            //			Console.WriteLine("Your result is " + RealCalculator);
            //			break;
            //		case "/":
            //			RealCalculator = number1 / number2;
            //			Console.WriteLine("Your result is " + RealCalculator);
            //			break;
            //		default:
            //			Console.WriteLine("You have entered a wrong operator, please try again");
            //			break;
            //			// mozhe i skrateno, so direkt kalulacija vo writeline, megjutao RealCalculator bese spomnato vo zadachata pa zatoa go ostaviv
            //	}
            //} else
            //         {
            //	Console.WriteLine("Please enter Integers only, refresh the page to try again");
            //         }

            #endregion

            #region Task2

            //Console.WriteLine("Please enter your first number and click Enter");
            //string input1 = Console.ReadLine();
            //int number1;
            //bool success1 = int.TryParse(input1, out number1);


            //Console.WriteLine("Please enter your second number and click Enter");
            //string input2 = Console.ReadLine();
            //int number2;
            //bool success2 = int.TryParse(input2, out number2);


            //Console.WriteLine("Please enter your third number and click Enter");
            //string input3 = Console.ReadLine();
            //int number3;
            //bool success3 = int.TryParse(input3, out number3);


            //Console.WriteLine("Please enter your fourth number and click Enter");
            //string input4 = Console.ReadLine();
            //int number4;
            //bool success4 = int.TryParse(input4, out number4);


            //int average = 0;

            //if (success1 && success2 && success3 && success4)
            //{
            //    average = (number1 + number2 + number3 + number4) / 4;
            //    Console.WriteLine("The average of the array of numbers is " + average);
            //    //can be calculated directly in the console, but i like order in my life 
            //} else
            //{
            //    Console.WriteLine("Please enter only integers, refresh to try again.");
            //}
            #endregion

            #region Task3

            //int number1 = 0;
            //int number2 = 0;
            //Console.WriteLine("Please enter your first number and click Enter");
            //string input1 = Console.ReadLine();
            //bool success1 = int.TryParse(input1, out number2);


            //Console.WriteLine("Please enter your second number and click Enter");
            //string input2 = Console.ReadLine();
            //bool success2 = int.TryParse(input2, out number1);

            //if (success1&&success2)
            //{
            //    Console.WriteLine("After the swap, the first number is " + number1 + " and the second number is " + number2);
            //} else
            //{
            //    Console.WriteLine("Please only enter integers. Refresh to try again");
            //}

            #endregion


            #region Task4

            //Console.WriteLine("Enter a number");
            //string input = Console.ReadLine();
            //int number;
            //bool success = int.TryParse(input, out number);

            //if (success)
            //{
            //    if (number % 3 == 0 && number % 5 != 0) //gave me an error when i wrote ===
            //    {
            //        Console.WriteLine("Tik");
            //    } else if (number % 5 == 0 && number % 3 != 0)
            //    {
            //        Console.WriteLine("Tak");
            //    } else if (number % 3 == 0 && number % 5 == 0)
            //    {
            //        Console.WriteLine("Tik-Tak");
            //    } else
            //    {
            //        Console.WriteLine("Bad Number");
            //    }
            //} else
            //{
            //    Console.WriteLine("Please only enter integers. Refresh to try again");
            //}

            Console.WriteLine("Enter a number");
            string input = Console.ReadLine();
            int number;
            bool success = int.TryParse(input, out number);

            bool byThree = (number % 3 == 0);
            bool byFive = (number % 5 == 0);

            if (success)
            {
                switch (byThree, byFive)
                {
                    case (true, false):
                        Console.WriteLine("Tik");
                        break;
                    case (false, true):
                        Console.WriteLine("Tak");
                        break;
                    case (true, true):
                        Console.WriteLine("Tik - Tak");
                        break;
                    default:
                        Console.WriteLine("Bad Number");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Please only enter integers. Refresh to try again");
            }


            //You said you wanted us to use more switch statements so i tried out this other option

            #endregion
        }
    }
}

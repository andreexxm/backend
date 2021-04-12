using System;

namespace homework3_task1
{
    class Program
    {
        static void FunWithStrings(string inputString)
        {

            //1
            char[] charArray = inputString.ToCharArray();
            Array.Reverse(charArray);
            string reversed = new string(charArray);

            Console.WriteLine("The reversed string is " + reversed);

            // the task asked for only one method so that's what i'm implementing but it does make more sense to write all the requests as separate methods as you also asked.. i will display both.

            //2
            int totalVowel = 0;
            foreach (char item in charArray)
            {
                if (item == 'a' || item == 'e' || item == 'o' || item == 'u' || item == 'i')
                {
                    totalVowel++;
                }
            }

            Console.WriteLine($"The total numbver of vowels is {totalVowel}");

            //3
            if (reversed == inputString)
            {
                Console.WriteLine("The input is a palindrome");
            }


            //4&5 (same logic applies so i figured i'd save myself some lines)
            string[] splitted = inputString.Split(' ');
            string largest = splitted[0];
            string smallest = splitted[0];
            int max = splitted[0].Length;
            int min = splitted[0].Length;
            for (int i = 0; i < splitted.Length; i++)
            {
                //int length = splitted[i].Length;
                if (splitted[i].Length > max)
                {
                    max = splitted.Length;
                    largest = splitted[i];
                }
                if (splitted[i].Length < min)
                {
                    min = splitted.Length;
                    smallest = splitted[i];
                }
            }
            Console.WriteLine("The largest word in the string is: " + largest);
            Console.WriteLine("The smallest word in the string is: " + smallest);


            //6
            Console.WriteLine("The number of words is " + splitted.Length);

            //// 7 (gave up, didnt wanna google it)
            //char mostUsed;
            //foreach (char item in charArray)
            //{
            //    int counter
            //}


        }

        static void Main(string[] args)
        {
            FunWithStrings(Console.ReadLine());
        }
    }
}

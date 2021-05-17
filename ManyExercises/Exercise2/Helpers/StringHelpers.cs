using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise2.Helpers
{
    public static class StringHelpers
    {
        public static string FirstLetter (this string str, int numberOfWords)
        {
            if (numberOfWords < 0)
                throw new ArgumentException("numberOfWords should be greater or equal to 0.");

            if (str.Length == 0)
                Console.WriteLine("Gimme something to work with");

            //char[] charArray = str.ToCharArray();

            //string result = charArray[0].ToString;

            List<char> charList = str.ToList();
            char firstLetter = charList
                                .FirstOrDefault();
                                  
            return firstLetter.ToString();

        }

        public static string LastLetter (this string str, int numberOfWords)
        {
            if (numberOfWords < 0)
                throw new ArgumentException("numberOfWords should be greater or equal to 0.");

            if (str.Length == 0)
                Console.WriteLine("Gimme something to work with");

            List<char> charList2 = str.ToList();
            char lastLetter = charList2
                                .LastOrDefault();

            return lastLetter.ToString();
        }
    }
}

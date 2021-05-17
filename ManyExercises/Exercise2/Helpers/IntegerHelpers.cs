using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise2.Helpers
{
    public static class IntegerHelpers
    {
        public static bool IsEven(this int num)
        {
            return (num % 2 == 0 ? true : false);
        }

        public static List<T> GetNFromList<T>(this List<T> myList, int num)
        {
            List<T> result = myList
                                .Take(num)
                                .ToList();
            return result;
        }
    }
}

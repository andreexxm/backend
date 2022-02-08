using System;

namespace class5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello DateTime!");

            DateTime emptyDate = new DateTime();

            DateTime customDate = new DateTime(2021, 4, 3);
            Console.WriteLine(customDate);

            string stringDate1 = "08-25-2000";
            string stringDate2 = "08.25.2000";
            string stringDate3 = "08/25/2000";
            string stringDate4 = "08/25/00";
            string stringDate5 = "august.25.2000";

            DateTime convertedDate = DateTime.Parse(stringDate5);
            Console.WriteLine(convertedDate);


            Console.ReadLine();
        }
    }
}

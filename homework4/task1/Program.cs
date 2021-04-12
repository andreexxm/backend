using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            DateTime currentDate = DateTime.Now;
            Console.WriteLine(currentDate);

            //2
            DateTime inTenYears = currentDate.AddYears(10);
            Console.WriteLine(inTenYears);

            //3
            DateTime substractedTime = currentDate.AddMonths(-2).AddDays(-15);
            Console.WriteLine(substractedTime);

            //4
            DateTime osmiMart = new DateTime(2022, 3, 8);
            Console.WriteLine(osmiMart.DayOfWeek);

            //5
            DateTime valentajProshli = new DateTime(2020, 2, 14);
            Console.WriteLine(valentajProshli.DayOfWeek);
        }
    }
}

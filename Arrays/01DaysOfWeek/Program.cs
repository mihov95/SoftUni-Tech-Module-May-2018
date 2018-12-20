using System;

namespace _01DaysOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {

            int day = int.Parse(Console.ReadLine());

            string[] daysOfWeek = new string[7]
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            if (day>7 || day <1)
            {
                Console.WriteLine("Invalid Day!");
            }
            else
            {
            Console.WriteLine(daysOfWeek[day-1]);

            }
            
        }
    }
}

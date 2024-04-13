using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5_ENUM
{
    internal class Program
    {
        enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            //Console.WriteLine(WeekDays.Friday); //output: Friday 

            //int day = (int)WeekDays.Friday; // enum to int conversion
            //Console.WriteLine(day); //output: 4 

            //var wd = (WeekDays)5; // int to enum conversion
            //Console.WriteLine(wd);

            var today = WeekDays.Saturday;

            if (today == WeekDays.Saturday || today == WeekDays.Sunday)
            {
                Console.WriteLine("It's the weekend!");
            }
            else
            {
                Console.WriteLine("It's a weekday.");
            }

            Console.ReadLine();
        }
    }
}

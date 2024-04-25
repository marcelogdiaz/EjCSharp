using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C7_EC_LOOPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //WHILE
            int x = 1;

            //SE EJECUTA 0 o MAS VECES
            //// Exit when x becomes greater than 4
            //while (x <= 4)
            //{
            //    Console.WriteLine($"{x} WHILE");

            //    // Increment the value of x for
            //    // next iteration
            //    x++;
            //}

            //SE EJECUTA 1 o MAS VECES
            //do
            //{
            //    Console.WriteLine($"{x} WHILE");

            //    // Increment the value of x for
            //    // next iteration
            //    x++;
            //} while (x <= 4);

            //for (int i = 0; i < 5; i++) { 
            //    Console.WriteLine(i);
            //}

            //for (int i = 0; i < 5; i=i+2)
            //{
            //    Console.WriteLine(i);
            //}

            for (int i = 0; i < 5; i--)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine(); 
        }
    }
}

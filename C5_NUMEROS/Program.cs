using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5_NUMEROS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine($"int.MinValue = {int.MinValue}");
            //Console.WriteLine($"int.MaxValue = {int.MaxValue}");
            //Console.WriteLine($"float.MinValue = {float.MinValue}");
            //Console.WriteLine($"float.MaxValue = {float.MaxValue}");
            //Console.WriteLine($"double.MinValue = {double.MinValue}");
            //Console.WriteLine($"double.MaxValue = {double.MaxValue}");
            //Console.WriteLine($"decimal.MinValue = {decimal.MinValue}");
            //Console.WriteLine($"decimal.MaxValue = {decimal.MaxValue}");
            //Console.WriteLine($"short.MinValue = {short.MinValue}");
            //Console.WriteLine($"short.MaxValue = {short.MaxValue}");
            //Console.WriteLine($"long.MinValue = {long.MinValue}");
            //Console.WriteLine($"long.MaxValue = {long.MaxValue}");

            //double numdouble = 3.78;
            //decimal numdecimal = 3.78M;
            //int entero;
            //entero = (int)numdouble;
            //entero = (int)numdecimal;
            //Console.WriteLine(entero);

            int i = 3;
            int j = i++;


            Console.WriteLine(i);
            Console.WriteLine(j);

            int k = ++i;

            int l = 5;
            //l += 9;

            l = +9;
            var valor = 16.8;
            int a = 20 / 10 / 2;
            int b = 20 / (10 / 2);
            Console.WriteLine(a);
            Console.WriteLine(b);

            if (a==b)
            {
                Console.WriteLine("A y B son iguales");
            }
            else
            {
                Console.WriteLine("A y B NO son iguales");
            }

            if (a != b)
            {
                Console.WriteLine("A y B son distintos");
            }
            else
            {
                Console.WriteLine("A y B NO son distintos");
            }
            Console.ReadLine();
        }
    }
}

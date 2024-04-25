using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C7_ED_ARRAY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaramos un arreglo de enteros
            int[] intArray;

            //alojar memoria para 5 enteros
            intArray = new int[5];
            intArray[0] = 1;
            intArray[1] = 20;
            intArray[2] = 30;
            intArray[3] = 40;
            intArray[4] = 50;

            //for (int i = 0; i < intArray.Length; i++) {
            //    Console.WriteLine(intArray[i]);
            //}

            //foreach (var item in intArray)
            //{
            //    Console.WriteLine(item);
            //}

            int j = -10;
            while (j < intArray.Length)
            {
                Console.WriteLine(intArray[j]);
                j++;
            }

            Console.ReadLine();
        }
    }
}

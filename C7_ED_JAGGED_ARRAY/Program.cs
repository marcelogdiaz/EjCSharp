using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C7_ED_JAGGED_ARRAY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare the Jagged Array of four elements:
            int[][] jagged_arr = new int[4][];
            /*
            [] ={ 1, 2, 3, 4 }
            [] ={ 11, 34, 67 }
            [] ={ 89, 23 }
            [] ={ 0, 45, 78, 53, 99 }
             * 
             * */


            // Initialize the elements
            jagged_arr[0] = new int[] { 1, 2, 3, 4 };
            jagged_arr[1] = new int[] { 11, 34, 67 };
            jagged_arr[2] = new int[] { 89, 23 };
            jagged_arr[3] = new int[] { 0, 45, 78, 53, 99 };

            for (int i = 0; i < jagged_arr.Length; i++)
            {// bucle de 4 iteraciones
             // Print the row number
                Console.Write("Fila({0}): ", i);
                for (int j = 0; j < jagged_arr[i].Length; j++)
                {
                    // Print the elements in the row
                    Console.Write("{0} ", jagged_arr[i][j]);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}

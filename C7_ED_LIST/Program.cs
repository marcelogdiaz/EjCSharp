using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C7_ED_LIST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating a List of integers
            // Here we are not setting
            // Capacity explicitly
            List<int> firstlist = new List<int>();
            firstlist.Add(1);
            firstlist.Add(2);
            firstlist.Add(3);
            firstlist.Add(4);

            firstlist[2] = 22;

            if (firstlist.Count == 5)
            {
                firstlist[4] = 33;
            }

            firstlist.RemoveAt(3);

            Console.ReadLine();

         }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C7_ED_STACK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Using Stack class
            Stack my_stack = new Stack();

            // Adding elements in the Stack
            // Using Push method
            my_stack.Push("Upso");
            my_stack.Push("Programacion");
            my_stack.Push("C#");
            my_stack.Push(null);
            my_stack.Push(1234);
            my_stack.Push(490.98);

            foreach(var item in my_stack)
            {
                Console.WriteLine(item); 
            }

            Console.ReadLine(); 
        }
    }
}

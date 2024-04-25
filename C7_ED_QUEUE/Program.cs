using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C7_ED_QUEUE
{
    internal class Program
    {
        /// <summary>
        /// Este es el metodo principal de ingreso al sistema
        /// </summary>
        /// <param name="args">Este parametro sire para ....</param>
        static void Main(string[] args)
        {

            //elegimos esta estructura porque.....
            Queue my_queue = new Queue();

            // Adding elements in Queue
            // Using Enqueue() method
            my_queue.Enqueue("UPSO");
            my_queue.Enqueue(1);
            my_queue.Enqueue(100);
            my_queue.Enqueue(null);
            my_queue.Enqueue(2.4);
            my_queue.Enqueue("C#-NET");

            //recorremos la estrucuta
            foreach (var item in my_queue)
            {
                Console.WriteLine(item);
            }

            //impr
            Console.WriteLine("Total elements present in my_queue: {0}", my_queue.Count);
            my_queue.Dequeue();

            //// After Dequeue method
            Console.WriteLine("Total elements present in my_queue: {0}",my_queue.Count);
            foreach (var item in my_queue)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}

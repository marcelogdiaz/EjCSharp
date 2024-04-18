using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5_STRING
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string a = "hello";
            string b = "h";
            // Append to contents of 'b'
            b += "ello";

            //IGUALDAD
            Console.WriteLine(a == b);
            Console.WriteLine(object.ReferenceEquals(a, b));
            Console.WriteLine(b);

            string c = "algo";
            b = c;
            a = b;

            Console.WriteLine("A apunta C");
            Console.WriteLine(object.ReferenceEquals(a, c));


            //CREACION DE STRING
            //from string literal and string concatenation
            //string fname, lname;
            //fname = "Rowan";
            //lname = "Atkinson";

            //char[] letters = { 'H', 'e', 'l', 'l', 'o' };

            //string fullname = (fname + lname);


            //Console.WriteLine("Full Name:" + fullname);
            //Console.WriteLine("Full Name: {0}", fullname);
            //Console.WriteLine($"Full Name: {fullname}");
            ////by using string constructor { 'H', 'e', 'l', 'l','o' };
            //string greetings = new string(letters);


            //string text = @"My pensive SARA ! thy soft cheek reclined
            //            Thus on mine arm, most soothing sweet it is
            //            To sit beside our Cot,...";

            //Console.WriteLine(text);

            string frase1 = "Her name was \"Sara.\"";
            string frase2 = @"Her name was ""Sara.""";
            //Console.WriteLine(frase1);

            if (frase1 == frase2)
            {
                Console.WriteLine("Frases iguales");
            }
            else {
                Console.WriteLine("Frases distintas");
            }


            Console.ReadLine();
        }
    }
}

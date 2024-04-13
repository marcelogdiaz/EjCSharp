using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5_BOOL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool valorBooleano = true;

            bool otroValorBooleano = false;
            //AND
            if (valorBooleano & otroValorBooleano)
            {
                Console.WriteLine("THEN");
            }
            else
            {
                Console.WriteLine("ELSE");
            }
            //or
            if (valorBooleano | otroValorBooleano)
            {
                Console.WriteLine("THEN");
            }
            else
            {
                Console.WriteLine("ELSE");
            }
            //XOR
            if (valorBooleano ^ otroValorBooleano)
            {
                Console.WriteLine("THEN");
            }
            else
            {
                Console.WriteLine("ELSE");
            }

            //OR
            //T, F = T
            // F,T = T
            //F,F=F
            //T,T=T

            //AND
            //T,F = F
            //F,T = F
            //F,F=F
            //T,T=T

            //XOR
            //T, F = T
            // F,T = T
            //F,F=F
            //T,T=F

            //Console.WriteLine(valorBooleano ? "Checked" : "Not checked");  // output: Checked
            Console.WriteLine(false ? "Checked" : "Not checked");  // output: Not checked

            ////PRECEDENCIA OPERADORES
            Console.WriteLine(true | true & false);   // output: True
            Console.WriteLine((true | true) & false); // output: False

            Console.ReadLine();
        }
    }
}

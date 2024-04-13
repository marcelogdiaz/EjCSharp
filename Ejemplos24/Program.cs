using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5_VariablesYConstantes
{
    internal class Program
    {

        /*
         * 
         * 
         * VARIABLEVAR 50
         * VARIABLE2 60
         * 
         * 
         */

        static void Main(string[] args)
        {
            //variables
            int variable;
            variable = 10;
            int variable2 = variable + 20;

            variable2 = 50;

            var variableVAR = variable2;
            //variableVAR = "frase";    ERROR EN COMPILACION
            Console.WriteLine(variableVAR);
            Console.WriteLine(variableVAR.GetType().ToString());

            //constantes
            const int CONSTANTEUNO = 25;
            const double PI = 3.1415;

            const string MINEGOCIO = "La Martina";

            Console.WriteLine(MINEGOCIO);

            Console.ReadLine();
        }
    }
}

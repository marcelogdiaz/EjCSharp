using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C8_CLASES.Entidades
{
    internal class Referi : Persona
    {
        public Referi(string nombre, string apellido, int edad) : base(nombre, apellido, edad)
        {
        }

        public override void Correr()
        {
            Console.WriteLine($"El REFERI {Apellido} esta corriendo");
        }
    }
}

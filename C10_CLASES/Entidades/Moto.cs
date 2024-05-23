using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10_CLASES.Entidades
{
    internal class Moto: Vehiculo
    {
        string color;

        public Moto(string marca, int cantidadRuedas, string c) : base(marca, cantidadRuedas)
        {
            this.color = c; 
        }

        public override void alinear()
        {
            Console.WriteLine("Alineamos MOTO {0}", marca);
        }

        public override void cambiarRueda()
        {
            Console.WriteLine("Cambiamos {0} rueda {1} en MOTO", cantidadRuedas, marca);
        }
    }
}

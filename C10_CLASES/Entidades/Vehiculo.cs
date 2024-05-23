using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C10_CLASES.Interfaces;

namespace C10_CLASES.Entidades
{
    internal class Vehiculo : IService
    {

        public string marca;
        public int cantidadRuedas;

        public Vehiculo(string marca, int cantidadRuedas)
        {
            this.marca = marca;
            this.cantidadRuedas = cantidadRuedas;
        }

        public virtual void alinear()
        {
            Console.WriteLine("Alineamos {0}", marca);
        }

        public virtual void cambiarRueda()
        {
            Console.WriteLine("Cambiamos {0} rueda {1}", cantidadRuedas, marca);
        }

        public void medirPresion()
        {
            Console.WriteLine("Medimos presion {0} vehiculo", marca);
        }
    }
}

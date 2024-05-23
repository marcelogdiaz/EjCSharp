using C10_CLASES.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10_CLASES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaramos una varible de tipo Vehiculo
            Vehiculo miVehiculo;
            //miVehiculo = new Vehiculo("Audi", 4);

            //Ahora creamos una Moto y vemos la diferencia de comportamiento con un Vehiculo
            miVehiculo = new Moto("Ducati", 2, "rojo");

            miVehiculo.alinear();
            miVehiculo.cambiarRueda();
            miVehiculo.medirPresion();

            Console.WriteLine("Presione ENTER para salir");
            Console.ReadLine();
        }
    }
}

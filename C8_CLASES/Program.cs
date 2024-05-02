using C8_CLASES.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C8_CLASES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Persona p = new Persona("Juan", "Perez", 33);
            //Console.WriteLine("Antes del cumple");
            //Console.WriteLine("{0}, {1}: {2}", p.Apellido, p.Nombre, p.Edad);

            //p.CumplirAnios();

            //Console.WriteLine("Despues del cumple");
            //Console.WriteLine("{0}, {1}: {2}", p.Apellido, p.Nombre, p.Edad);
            //Console.ReadLine();

            //creamos un jugador en particular
            Jugador j10 = new Jugador("Lionel", "Messi", 36, "delantero");

            Console.WriteLine("{0}, {1}: {2} - {3}", j10.Apellido, j10.Nombre, j10.Edad, j10.Posicion);
            Console.ReadLine();

            //armamos un equipo de futbol con jugadores random
            List<Jugador> equipoLocal = new List<Jugador>();
            //cargar equipo Local
            for (int i = 1; i < 12; i++)
            {
                equipoLocal.Add(new Jugador($"JLocal{i}", $"ApLocal{i}", 25, i.ToString()));
            }

            Random valor = new Random();
            int ivalor = valor.Next(0, 12);
            //mandamos a Precalentar a un jugador cualquiera
            equipoLocal.ElementAt(ivalor).Precalentar();

            Console.ReadLine();
        }
    }
}

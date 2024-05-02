using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C8_CLASES.Entidades
{
    internal class Jugador : Persona
    {
        //campos propios para modelar el problema de un jugador
        #region PROPERTIES
        private int infracciones;
        private string posicion;

        public int Infracciones { get => infracciones; set => infracciones = value; }
        public string Posicion { get => posicion; set => posicion = value; }
        #endregion

        /// <summary>
        /// Constructor que llama al constructor de Persona
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="edad"></param>
        /// <param name="posicion"></param>
        /// <param name="infracciones"></param>
        public Jugador(string nombre, string apellido, int edad, string posicion, int infracciones = 0) : base(nombre, apellido, edad)
        {
            Infracciones = infracciones;
            Posicion = posicion;
        }

        //Metodos propios de un jugador
        public void Correr()
        {
            Console.WriteLine($"El JUGADOR {Apellido} esta corriendo");
        }

        public void Precalentar()
        {
            Console.WriteLine($"El JUGADOR {Apellido} esta precalentando");
        }

        public void TarjetaAmarilla()
        {
            Console.WriteLine($"El JUGADOR {Apellido} recibió tarjeta AMARILLA");
        }

        public void TarjetaRoja()
        {
            Console.WriteLine($"El JUGADOR {Apellido} recibió tarjeta ROJA");
        }

        public void Falta()
        {
            Console.WriteLine($"El JUGADOR {Apellido} cometió una FALTA");
        }

    }
}

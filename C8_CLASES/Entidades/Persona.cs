using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C8_CLASES.Entidades
{
    internal abstract class Persona
    {
        #region PROPERTIES
        /// <summary>
        /// Variable para almacenar el nombre de una Persona
        /// </summary>
        private string nombre;
        private string apellido;
        private int edad;
        //Perez, perez, PEREZ

        public string Nombre { get; set; }  //version reducida de property
        public string Apellido { get => apellido; set => apellido = value.ToUpper(); }  //version personalizada de property
        public int Edad { get => edad; set => edad = value; }   //version ampliada de property
        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// Metodo para crear un objeto de la clase Persona
        /// </summary>
        /// <param name="nombre">Permite especificar el nombre de una persona</param>
        /// <param name="apellido"></param>
        /// <param name="edad"></param>
        public Persona(string nombre, string apellido, int edad)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
        }

        /// <summary>
        /// Metodo que incrementa la edad actual en 1.
        /// </summary>
        /// <returns>Retorna la edad cumplida.</returns>
        public int CumplirAnios()
        {
            Edad = Edad + 1;
            return Edad;
        }

        //public virtual void Correr() {
        //    Console.WriteLine("La persona esta corriendo");
        //}

        public abstract void Correr();

        public virtual void Precalentar() {
            Console.WriteLine("La persona esta precalentando");
        }
        #endregion

    }
}

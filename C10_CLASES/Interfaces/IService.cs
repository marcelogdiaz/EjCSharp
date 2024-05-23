using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10_CLASES.Interfaces
{
    internal interface IService
    {
        /// <summary>
        /// Funcionalidad para cambiar una rueda, sin implementacion
        /// </summary>
        void cambiarRueda();

        /// <summary>
        /// Funcionalidad para alinear una rueda, sin implementacion
        /// </summary>
        void alinear();

        /// <summary>
        /// Funcionalidad para medir la presion, sin implementacion
        /// </summary>
        void medirPresion();
    }
}

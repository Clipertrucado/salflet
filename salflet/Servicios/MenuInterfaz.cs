using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salflet.Servicios
{
    internal interface MenuInterfaz
    {
        /// <summary>
        /// muestra las diferentes funciones de nuestra aplicacion, pide un tipo int y lo devuelve
        /// SAV - 04122023
        /// </summary>
        /// <returns></returns>
        public int menuSeleccion();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salflet.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int menuSeleccion()
        {
            int seleccion;

            Console.WriteLine("Seleccione una de las opciones:");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("          1. Añadir elemento a la lista ");
            Console.WriteLine("          2. Disminuir un elemento a la lista ");
            Console.WriteLine("          2. Mostrar los elemento de la lista ");
            Console.WriteLine("          0. Cerrar");
            Console.WriteLine("---------------------------------------------------------");

            seleccion = Convert.ToInt32(Console.ReadLine());

            return seleccion;

        }
    }
}

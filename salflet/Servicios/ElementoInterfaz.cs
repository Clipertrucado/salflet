using salflet.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salflet.Servicios
{
    /// <summary>
    /// contiene las cabeceras de los metodos a los que llamaremos desde el metodo Main
    /// SAV - 12042023
    /// </summary>
    internal interface ElementoInterfaz
    {
        /// <summary>
        /// sera el encargado de añadir un nuevo elemento a la lista 
        /// /// SAV - 04122023
        /// </summary>
        /// <param name="listaCompleta"></param>
        public void añadirElemento(List<ElementoDto> listaCompleta);

        /// <summary>
        /// Nos mostrara todo los elementos guardados en la lista actualmente
        /// SAV - 04122023
        /// </summary>
        /// <param name="listaCompleta"></param>
        public void mostraLista(List<ElementoDto> listaCompleta);

        /// <summary>
        /// con esta funcion podremos disminuir la cantidad de un elemento que tengamos en la lista 
        /// SAV - 04122023
        /// </summary>
        /// <param name="listaCompleta"></param>
        public void editarLista(List<ElementoDto> listaCompleta);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salflet.Datos
{   
    /// <summary>
    /// contiene toda la estructura de nuestra lista
    /// SAV - 04122023
    /// </summary>
    internal class ElementoDto
    {
        //CREAMOS LAS VARIBLES QUE COMPONEN NUESTRA LISTA 

        long idElemento = 0;
        string codigoElemento = "aaaaa";
        string nombreElemento = "aaaaa";
        string descripcionElemento = "aaaaa";
        int cantidadElemento = 0;

        //METODOS GET Y SET CON LOS QUE LEEMOS O ESBRIBIMOS EL LA LISTA

        public long IdElemento { get => idElemento; set => idElemento = value; }
        public string CodigoElemento { get => codigoElemento; set => codigoElemento = value; }
        public string NombreElemento { get => nombreElemento; set => nombreElemento = value; }
        public string DescripcionElemento { get => descripcionElemento; set => descripcionElemento = value; }
        public int CantidadElemento { get => cantidadElemento; set => cantidadElemento = value; }

        
        /// <summary>
        /// creamos un constructor que tontiene todos los parametros
        /// SAV - 04122023
        /// </summary>
        /// <param name="idElemento"></param>
        /// <param name="codigoElemento"></param>
        /// <param name="nombreElemento"></param>
        /// <param name="descripcionElemento"></param>
        /// <param name="cantidadElemento"></param>
        public ElementoDto(long idElemento, string codigoElemento, string nombreElemento, string descripcionElemento, int cantidadElemento)
        {
            this.idElemento = idElemento;
            this.codigoElemento = codigoElemento;
            this.nombreElemento = nombreElemento;
            this.descripcionElemento = descripcionElemento;
            this.cantidadElemento = cantidadElemento;
        }

        /// <summary>
        /// creamos un constructor sin parametros
        /// SAV - 04122023
        /// </summary>
        public ElementoDto()
        {
        }

        /// <summary>
        /// creamos nuestro metodo ToString que nos devolvera una string con todos los parametros que tenemos en nuestra lista
        /// SAV - 04122023
        /// </summary>
        /// <returns></returns>
        override
        public string ToString()
        { 
            string elemento = "ID: " + this.idElemento + 
                              ", Codigo: " + codigoElemento +
                              ", Nombre: "+ this.nombreElemento + 
                              ", Descripcion: "+ this.descripcionElemento + 
                              ", Cantidad: " + this.cantidadElemento;

            return elemento;
        
        }
    }
}

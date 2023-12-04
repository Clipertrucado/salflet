using salflet.Datos;
using salflet.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salflet.Controladores
{
    /// <summary>
    /// clase principal de nuestra aplicación
    /// SAV - 04122023
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// contendra el flujo principal de la aplicación
        /// SAV - 04122023
        /// </summary>
        public static void Main() { 
            
            //creamos variables de tipo xinterfaz para poder llamar a los metodos que contienen
            MenuInterfaz mi = new MenuImplementacion();
            ElementoInterfaz ei = new ElementoImplementacion();

            //creamos list tipo lista que tiene la referencia de memoria donse se guardan los elementos de toda nuestra lista
            List<ElementoDto> list = new List<ElementoDto>();

            bool cerrar = false;

            //while con el que haremos que el cliente se mantenga en bucle hata que seleccione lo contrario
            while (!cerrar)
            {
                //mostramos el menu y le damos a op el valor seleccionado
                int op = mi.menuSeleccion(); 

                //usamos op con un Switch para controlar que opcion se a seleccionado
                switch (op)
                {
                    case 0:
                        //cerramos el bucle
                        cerrar = true;
                        break;
                    case 1:
                        //llamamos a metodo y le pasamos la lista
                        ei.añadirElemento(list);
                        break;
                    case 2:
                        //llamamos a metodo y le pasamos la lista
                        ei.editarLista(list);
                        break;
                    case 3:
                        //llamamos a metodo y le pasamos la lista
                        ei.mostraLista(list);
                        break;
                }

            }
        
        }
    }
}

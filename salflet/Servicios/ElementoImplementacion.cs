using salflet.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace salflet.Servicios
{
    internal class ElementoImplementacion : ElementoInterfaz
    {
       

        public void añadirElemento(List<ElementoDto> listacompleta)
        {
            //igualamos nuestro elemento con un metodo que creara y devolvera un tipo elementoDto y de esta forma abstraer el codigo
            ElementoDto elemento = crearElemento();

            //añadimos a nuestra lista el elemento creado 
            listacompleta.Add(elemento);
            
            mostraNombre(listacompleta);
        }

        /// <summary>
        /// este metodo creara y devuelve un elemento que contenga los datos que el cliente introduzca 
        /// SAV - 04122023
        /// </summary>
        /// <returns></returns>
        private ElementoDto crearElemento() { 

            ElementoDto nuevoElemento = new ElementoDto();

            Console.WriteLine("Completa:");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Id del elemento: ");
            long id = Convert.ToInt64(Console.ReadLine());
            nuevoElemento.IdElemento= id;

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Nombre del elemento: ");
            string nombre = Console.ReadLine();
            nuevoElemento.NombreElemento = nombre;

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Descripcion del elemento: ");
            
            nuevoElemento.DescripcionElemento = Console.ReadLine();

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Cantidad del elemento: ");
            nuevoElemento.CantidadElemento = Convert.ToInt32(Console.ReadLine());

            nuevoElemento.CodigoElemento = id + nombre;

            return nuevoElemento;
        }

        public void mostraLista(List<ElementoDto> listaCompleta)
        {
            //mostramso mediante un foreach todas las posiciones de la lista
            foreach (ElementoDto elemento in listaCompleta) { 
                Console.WriteLine(elemento.ToString()); 
            }

            
        }
        private void mostraNombre (List<ElementoDto> listaCompleta)
        {
            //mostramso mediante un foreach todas las posiciones de la lista
            foreach (ElementoDto elemento in listaCompleta)
            {
               
                

                Console.WriteLine("Nombre: " + elemento.NombreElemento + ", Cantidad: " + elemento.CantidadElemento);
            }


        }

        public void editarLista(List<ElementoDto> listaCompleta)
        {
            mostraLista(listaCompleta);

            
            Console.WriteLine("Ingresa el codigo del elemento que desea modificar");
            string codigo= Console.ReadLine();

            foreach (ElementoDto elemento in listaCompleta) {

                if (elemento.CodigoElemento.Equals(codigo))
                {

                    Console.WriteLine("Cantidad: " + elemento.CantidadElemento);
                    int op = opcionesPeticion();

                    //controlamso segun op que caso selecciono el cliente
                    switch (op)
                    {
                        default:
                            break;
                        case 1:

                            //pedimos la cantidad a disminuir 
                            Console.WriteLine("Ingrese la cantidad que desea disminuir:");
                            int reducir = Convert.ToInt32(Console.ReadLine());

                            //solo podremos disminuir hasta que le valor llegue a 0 si le pide reducir una cantidad mayor a la existente
                            //no se reducira y se dira que no es posible reducir segun la cantidad introducida 
                            if (reducir <= elemento.CantidadElemento)
                            {

                                elemento.CantidadElemento = elemento.CantidadElemento - reducir;

                                mostraNombre(listaCompleta);

                            }
                            else
                            {

                                Console.WriteLine("La cantidad a reducir tiene que ser menor a igual a la cantidad  de existencias");

                            }


                            break;
                        case 2:
                            break;

                    }
                }
                else {

                    Console.WriteLine("No existe el codigo introducido");
                    break;
                }
            
            
            }
        }

        /// <summary>
        /// metodo que nos preguntara si deseamos modificar el elemeto introducido si lo hay y devuelve un tipo int 
        /// </summary>
        /// <returns></returns>
        private int opcionesPeticion() {


            Console.WriteLine("¿Deseas modificar el elemento?");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("1. Si");
            Console.WriteLine("2. No");
            Console.WriteLine("----------------------------------------");

            int op = Convert.ToInt32(Console.ReadLine());

            return op;

        }

       
    }
}

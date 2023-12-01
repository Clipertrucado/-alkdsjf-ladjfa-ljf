using pinpanpun.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pinpanpun.Servicios
{
    internal class ClienteImplementacion : ClienteInterfaz
    {
        public void addCliente(List<ClienteDto> listaCliente)
        {
            ClienteDto cliente = crearCliente();
            listaCliente.Add(cliente);
        }

       

        private ClienteDto crearCliente() { 

            ClienteDto cliente = new ClienteDto();

            Console.WriteLine("Introduzca el id:");          
            cliente.IdCliente= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduzca el Nombre:");
            cliente.NombreCliente =Console.ReadLine();

            Console.WriteLine("Introduzca el Apellido:");
            cliente.Apellidocliente = Console.ReadLine();

            Console.WriteLine("Introduzca el DNI:");
            cliente.DniCilente = Console.ReadLine();

            Console.WriteLine("Introduzca la Edad:");
            cliente.EdadCliente = Convert.ToInt32(Console.ReadLine());

            
            return cliente;
        }

        public void mostrarCliente(List<ClienteDto> listaCompleta)
        {
            foreach (var cliente in listaCompleta)
            {

                Console.WriteLine(cliente);

            }
        }

        private int modificarMenuSeleccion()
        {
            int select;

            Console.WriteLine("     ¿Qué dato desea modificar?");

            Console.WriteLine("               1.NOMBRE");
            Console.WriteLine("               2.APELLIDO");
            Console.WriteLine("               3.DNI");
            Console.WriteLine("               3.EDAD");

            select = Convert.ToInt32(Console.ReadLine());

            return select;
        }
        
        private long pedirId() {

            Console.WriteLine("Indica el id del cliente a modificar");

            long i = Convert.ToInt64(Console.ReadLine());

            return i;

        }



        public void modificarCliente(List<ClienteDto> listaCompleta)
        {

            mostrarCliente(listaCompleta);

            
            long i = pedirId();

            foreach (var cliente in listaCompleta) {

                if (cliente.IdCliente == i) {

                    int select=modificarMenuSeleccion();

                    switch (select)
                    {

                        case 1: 
                            Console.WriteLine("Introduzca el Nombre:");
                            cliente.NombreCliente = Console.ReadLine();
                            break;
                            
                        case 2:
                            Console.WriteLine("Introduzca el Apellido:");
                            cliente.Apellidocliente = Console.ReadLine();
                            break;

                        case 3:
                            Console.WriteLine("Introduzca el DNI:");
                            cliente.DniCilente = Console.ReadLine();
                            break;

                        case 4:
                            Console.WriteLine("Introduzca la Edad:");
                            cliente.EdadCliente = Convert.ToInt32(Console.ReadLine());
                        break;

                        default:
                            break;

                    }
                  

                }

            }

        }

        public void borrarClinte(List<ClienteDto> listaCompleta)
        {
            long f = pedirId();          
            bool x = false;
            int i;
            for (i = 0; i < listaCompleta.Count(); i++)
            {
                if (listaCompleta[i].IdCliente == f) {

                    x = true;   
                    break;

                }
            }
            
            if (x)
            {

                listaCompleta.RemoveAt(i);
            
            }
            
            
        }
    }
}

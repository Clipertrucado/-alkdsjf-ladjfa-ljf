using pinpanpun.Datos;
using pinpanpun.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pinpanpun.Controladores
{
    internal class Program
    {
        public static void Main() { 
        
            MenuInterfaz mi = new MenuImplementacion();
            ClienteInterfaz ci = new ClienteImplementacion();
            CuentaInterfaz cu = new CuentaImplementacion();


            List<ClienteDto> listaCliente = new List<ClienteDto>();
            List<CuentaDto> listacuenta = new List<CuentaDto>();
            
            

            bool cerrar = false;

            while (!cerrar)
            {
                int seleccion = mi.menuSeleccion();

                switch (seleccion)
                {
                    case 0:
                        
                        break;

                    case 1:
                        ci.addCliente(listaCliente);
                        break;

                    case 2:
                        ci.mostrarCliente(listaCliente);
                        break;

                    case 3:
                        ci.borrarClinte(listaCliente);
                        break;

                    case 4:
                        ci.modificarCliente(listaCliente);
                        break;

                    default: 
                        break;

                }
            }


        
        }
    }
}

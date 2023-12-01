using pinpanpun.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pinpanpun.Servicios
{
    internal interface ClienteInterfaz
    {
        public void addCliente(List<ClienteDto> listaCliente);

        public void mostrarCliente(List<ClienteDto> listaCompleta);

        public void modificarCliente(List<ClienteDto> listaCompleta);

        public void borrarClinte(List<ClienteDto> listaCompleta);

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pinpanpun.Datos
{
    internal class ClienteDto
    {
        long idCliente = 1111111111;
        string nombreCliente= "aaaaa" ;
        string apellidocliente = "aaaaa";
        int edadCliente= 111111111;
        string dniCilente = "aaaaa";

        public long IdCliente { get => idCliente; set => idCliente = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string Apellidocliente { get => apellidocliente; set => apellidocliente = value; }
        public int EdadCliente { get => edadCliente; set => edadCliente = value; }
        public string DniCilente { get => dniCilente; set => dniCilente = value; }

        public ClienteDto(long idCliente, string nombreCliente, string apellidocliente, int edadCliente, string dniCilente)
        {
            this.idCliente = idCliente;
            this.nombreCliente = nombreCliente;
            this.apellidocliente = apellidocliente;
            this.edadCliente = edadCliente;
            this.dniCilente = dniCilente;
        }

        public ClienteDto()
        {
        }

        override
        public string ToString()
        {
            string cliente =   " Id:" + this.idCliente +
                               ", Nombre:" + this.nombreCliente +
                               ", Apellido:" + this.apellidocliente +
                               ", Edad:" + this.edadCliente +
                               ", DNI:" + this.dniCilente;

            return cliente;
        }


           
       
    }
}

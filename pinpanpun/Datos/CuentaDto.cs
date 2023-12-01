using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pinpanpun.Datos
{
    internal class CuentaDto
    {
        int idCuenta = 11111;
        int ibanCuenta = 111111;
        string nombreCuenta = "aaaaaaa";

        public int IdCuenta { get => idCuenta; set => idCuenta = value; }
        public int IbanCuenta { get => ibanCuenta; set => ibanCuenta = value; }
        public string NombreCuenta { get => nombreCuenta; set => nombreCuenta = value; }

        public CuentaDto() { 

        }

        public CuentaDto(int idCuenta, int ibanCuenta, string nombreCuenta)
        {
            this.idCuenta = idCuenta;
            this.ibanCuenta = ibanCuenta;
            this.nombreCuenta = nombreCuenta;
        }

        override
        public string ToString(){
            string cliente = "";
        
            return cliente;
        }
    }
}

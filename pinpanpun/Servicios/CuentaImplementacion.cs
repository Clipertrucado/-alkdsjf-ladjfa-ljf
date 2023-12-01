using pinpanpun.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pinpanpun.Servicios
{
    internal class CuentaImplementacion : CuentaInterfaz
    {
        public void addCuenta(List<CuentaDto> listaCuenta)
        {
           CuentaDto cuentaNueva = crearCuenta();
           listaCuenta.Add(cuentaNueva);
        }

        private CuentaDto crearCuenta() { 
            
            CuentaDto cuenta = new CuentaDto();

            Console.WriteLine("Introduzca el id:");
            cuenta.IdCuenta=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduzca el codigo Iban:");
            cuenta.IbanCuenta = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduzca el Apellido:");
            cuenta.NombreCuenta = Console.ReadLine();

            return cuenta;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pinpanpun.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int menuSeleccion()
        {
            int i;

            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("               1.Crear un cliente");
            Console.WriteLine("               2.Mostrar los clintes");
            Console.WriteLine("               3.Eliminiar los clientes");
            Console.WriteLine("               3.Modificar un clinete");
            Console.WriteLine("---------------------------------------------------------");

            i = Convert.ToInt32(Console.ReadLine());

            return i;
            
        }
    }
}

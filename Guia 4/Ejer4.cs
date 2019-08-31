using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_4
{
    class Ejer4
    {
        public void ejerCuatro()
        {
            int cont = 1;
            decimal total=0.00M,  ventas=0, bono;
            do
            {
                Console.Clear();
                Console.WriteLine("Ingrese valor de venta Nª "+cont);
                Console.WriteLine("Ingrese < -1 > para salir.");
                decimal.TryParse(Console.ReadLine(),out ventas);
                cont++;
                total = total + ventas;
            } while (ventas!=-1);
            total = total + 1;
            bono = total * 0.05M;
            Console.Clear();
            Console.WriteLine("Ventas realizadas: "+(cont-2));
            Console.WriteLine("Venta total: "+total.ToString("C2"));
            Console.WriteLine("Bono (5%): "+bono.ToString("C2"));

            Console.WriteLine("Presione <ENTER> para continuar...");
            Console.ReadKey();
        }
    }
}

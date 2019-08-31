using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_4
{
    class Ejer1
    {
        public void ejerUno()
        {
            decimal sueldo = 0.00m, total =0.00m, promedio = 0.00m;
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Empleado Nª "+i);
                Console.WriteLine("Ingrese sueldo: ");
                decimal.TryParse(Console.ReadLine(), out sueldo);
                total = total + sueldo;
            }

            promedio = total / 20;
            Console.WriteLine("Sueldo total: "+total);
            Console.WriteLine("Sueldo Promedio: "+promedio);

            Console.WriteLine("Presione <ENTER> para continuar...");
            Console.ReadKey();
        }
    }
}

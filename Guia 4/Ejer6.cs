using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_4
{
    class Ejer6
    {
        public void ejerSeis()
        {
            //cuantas sucursales
            //ventas de cada sucursal
            // mostrar promedio de vetas por sucursal y global

            int sucursal;
            int cont = 1;
            decimal total = 0.00M, ventas = 0;
            decimal totalGlobal = 0.00M, promedioGlobal = 0.00M, promedio;

            Console.WriteLine("ingrese cantidad de sucursales: ");
            int.TryParse(Console.ReadLine(), out sucursal);

            for (int i = 0; i < sucursal; i++)
            {
                total = 0.00M;
                ventas = 0;
                cont = 1;
                do
                {
                    Console.Clear();
                    Console.WriteLine("SUCURSAL Nª " + (i+1));
                    Console.WriteLine("Ingrese valor de venta Nª " + cont);
                    Console.WriteLine("Ingrese < 0 > para salir.");
                    decimal.TryParse(Console.ReadLine(), out ventas);
                    cont++;
                    total = total + ventas;
                } while (ventas != 0);
                //total = total + 1;
                promedio = total / (cont-2);
                Console.Clear();
                Console.WriteLine("SUCURSAL Nª " + (i+1));
                Console.WriteLine("Ventas realizadas: " + (cont - 2));
                Console.WriteLine("Venta total: " + total.ToString("C2"));
                Console.WriteLine("Promedio de ventas: " + promedio.ToString("C2"));
                totalGlobal = totalGlobal + total;
                promedioGlobal = promedioGlobal + promedio;
                Console.WriteLine("Presione <ENTER> para continuar...");
                Console.ReadKey();
            }
            Console.Clear();
            Console.WriteLine("\nTotal de ventas Global: " + totalGlobal.ToString("C2"));
            Console.WriteLine("Promedio de ventas Global: "+promedioGlobal.ToString("C2"));

            Console.WriteLine("\n Presione <ENTER> para continuar...");
            Console.ReadKey();
        }

    }
    
}

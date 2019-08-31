using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            do
            {
                Console.Clear();
                Console.WriteLine("Seleccione ejerciccio a Ejecutar");
                Console.WriteLine("\n * 1 * Promedio y total de sueldo de 20 empleados.");
                Console.WriteLine("\n * 2 * Calificacion y Asistencia.");
                Console.WriteLine("\n * 3 * Cantidad de vocales.");
                Console.WriteLine("\n * 4 * Total y bonificacion de ventas realizadas.");
                Console.WriteLine("\n * 5 * Contraseña, 3 intentos.");
                Console.WriteLine("\n * 6 * Ventas por sucursales.");
                Console.WriteLine("\n * 7 * Salir.");
                Console.WriteLine("\n * Selecciona una opccion *");
                int.TryParse(Console.ReadLine(), out op);
                switch (op)
                {
                    case 1:
                        Console.Clear();
                        Ejer1 a = new Ejer1();
                        a.ejerUno();                        
                        break;
                    case 2:
                        Console.Clear();
                        Ejer2 b = new Ejer2();
                        b.ejerDos();
                        break;
                    case 3:
                        Console.Clear();
                        Ejer3 c = new Ejer3();
                        c.ejerTres();
                        break;
                    case 4:
                        Console.Clear();
                        Ejer4 d = new Ejer4();
                        d.ejerCuatro();
                        break;
                    case 5:
                        Console.Clear();
                        Ejer5 e = new Ejer5();
                        e.ejerCinco();
                        break;
                    case 6:
                        Console.Clear();
                        Ejer6 f = new Ejer6();
                        f.ejerSeis();
                        break;
                    default:
                        break;
                }
            } while (op != 7);

            Console.WriteLine("Presione <ENTER> para continuar...");
            Console.ReadKey();
        }
    }
}

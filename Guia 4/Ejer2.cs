using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_4
{
    class Ejer2
    {
        public void ejerDos()
        {
            int cant, aprov=0, reprovCal=0, reprovAsist=0;
            double cal, asist;
            Console.WriteLine("Cantidad de alumnos: ");
            int.TryParse(Console.ReadLine(), out cant);
            for (int i = 0; i < cant; i++)
            {
                Console.WriteLine("Alumno Nª "+i);
                do
                {
                    Console.WriteLine("Ingrese Calificacion: (1-10)");
                    double.TryParse(Console.ReadLine(), out cal);
                } while (cal<=10 && cal>=1);
                do
                {
                    Console.WriteLine("Ingrese Asistencia: (1-100)");
                    double.TryParse(Console.ReadLine(), out asist);
                } while (asist<=100 && asist>=1);
               

                if (cal >= 7.0 && asist >= 75)
                {
                    Console.WriteLine("Alumno Nª "+i+" Aprovado");
                    aprov = aprov ++;
                }
                else
                {                    
                    if (asist<75)
                    {
                        Console.WriteLine("Reprobado por Inasistencia.");
                        reprovAsist = reprovAsist++;
                    }
                    else
                    {
                        if (cal<7)
                        {
                            Console.WriteLine("Reprobado por Calificacion.");
                            reprovCal = reprovCal++;
                        }
                    }
                   
                }
               
            }

            Console.WriteLine("Presione <ENTER> para continuar...");
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_4
{
    class Ejer5
    {
        public void ejerCinco()
        {
            String contra = "1234",contra1;
            int cont = 0;
            do
            {
                Console.WriteLine("Ingrese contraseña");
                contra1 = Console.ReadLine();
                if (contra1!=contra) 
                {
                    Console.WriteLine("Contraseña no valida");
                    Console.WriteLine("");
                    cont++;
                    Console.WriteLine("Pista: " + contra.Substring(0, cont));
                }
            } while (contra1 != contra && cont <= 3);
            if (cont == 3 && contra1!=contra)
            {
                Console.WriteLine("Limite de intentos alcanzado");
                Console.WriteLine("Presiona <ENTER> para continuar.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Contraseña correcta");
                Console.WriteLine("Presiona <ENTER> para continuar.");
                Console.ReadKey();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_4
{
    class Ejer3
    {
        public void ejerTres()
        {
            string nombre;
            int contA=0, contE=0, contI=0, contO=0, contU=0;
            Console.WriteLine("Ingrese nombre: ");
            nombre = Console.ReadLine();
            for (int i = 0; i < nombre.Length; i++)
            {
                if ((nombre[i] == 'a')||(nombre[i]=='á')||(nombre[i]=='A'))
                {
                    contA++;
                }
                if ((nombre[i] == 'e') || (nombre[i] == 'é') || (nombre[i] == 'E'))
                {
                    contE++;
                }
                if ((nombre[i] == 'i') || (nombre[i] == 'í') || (nombre[i] == 'I'))
                {
                    contI++;
                }
                if ((nombre[i] == 'o') || (nombre[i] == 'ó') || (nombre[i] == 'O'))
                {
                    contO++;
                }
                if ((nombre[i] == 'u') || (nombre[i] == 'ú') || (nombre[i] == 'U'))
                {
                    contU++;
                }
            }
            Console.WriteLine("Cantidad de vocales: ");
            Console.WriteLine("Cantidad * A *" + contA);
            Console.WriteLine("Cantidad * E *" + contE);
            Console.WriteLine("Cantidad * I *" + contI);
            Console.WriteLine("Cantidad * O *" + contO);
            Console.WriteLine("Cantidad * U *" + contU);

            Console.WriteLine("Presione <ENTER> para continuar...");
            Console.ReadKey();
        }
    }
}

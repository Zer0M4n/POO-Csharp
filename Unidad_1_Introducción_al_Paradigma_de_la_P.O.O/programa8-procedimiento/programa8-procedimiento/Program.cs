using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa8_procedimiento
{
    
    internal class Program
    {
        static void suma()
        {//precedimiento suma
            //declara variables
            short numero1 = 0, numero2 = 0, suma = 0;
            
            //capturar datos
            Console.Write("Numero1: ");
            numero1 = short.Parse(Console.ReadLine());

            Console.Write("Numero: 2");
            numero2 = short.Parse(Console.ReadLine());

            //proceso de datos

            suma =(short)(numero1 + numero2);

            //imprimir datos

            Console.Write("El resultado es {0}", suma);

            Console.Write("\nPRESIONE ENTER PARA SALIR");
            Console.ReadKey();

        }
        static void Main(string[] args)
        {
            suma();
        }
    }
}

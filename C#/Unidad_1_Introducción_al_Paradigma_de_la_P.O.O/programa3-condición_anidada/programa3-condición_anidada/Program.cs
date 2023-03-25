using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa3_condición_anidada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PROGRAMA PARA SABER CUAL ES EL MAYOR O SI SON IGUALES DE DOS NUMEROS CON CONDICION ANIDADA

            //Declarar varibles
 

            short numero1 = 0, numero2 = 0;

            //ENTRADA DE datos

            Console.Write("Numero 1: ");
            numero1 = short.Parse(Console.ReadLine());

            Console.Write("Numero 2: ");
            numero2= short.Parse(Console.ReadLine());   

            //Proceso de la condicional anidada

            if (numero1 == numero2) //en caso de iguales
            {
                Console.Write("LOS NUMEROS IGUALES");
            }
            else if (numero2 > numero1) //numero 2 es el mayor
            {
                Console.Write("El numero es {0} es el mayor",numero2);
            }
            else if(numero1 > numero2) //numero1 es el mayor
            {
                Console.Write("El numero es {0} es el mayor", numero1);
            }


            Console.WriteLine("\nFIN DEL PROGRAMA , PRECIONE ENTER PARA CERRAR");
            Console.ReadKey();
            //FIN DEL PROGRAMA

        }
    }
}

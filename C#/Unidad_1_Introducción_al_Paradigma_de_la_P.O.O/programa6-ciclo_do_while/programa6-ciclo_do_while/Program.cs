using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa6_ciclo_do_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Imprimir 10 numeros pares con un ciclo do while
            //declarar varibles
            
            short i = 0; //Declaramos un contador

            do//verifica si cumpla premisa primero antes que comiense el ciclo
            {
                i = (short)(i + 2); //incremento 
                Console.WriteLine(i);

            } while (i < 10);//verifica si la premisa es cierta para repetir el ciclo

            Console.WriteLine("Precione enter para cerrar el programa");
            Console.ReadKey();
        }
    }
}

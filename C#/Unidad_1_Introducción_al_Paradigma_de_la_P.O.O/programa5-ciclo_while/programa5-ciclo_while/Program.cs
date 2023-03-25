using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa5_ciclo_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //imprimir diez numeros con do while

            sbyte  i = 0;//declaramos el contador
            while (i < 10) //Comprueva si la premicia es cierta 
            {
                i++;
                Console.WriteLine(i);//imprime el valor de la condicion
            }
            Console.Write("\nTERMINI EL PROGRAMA , PRECIONE ENTER PARA CERRAR");
            Console.ReadKey();
        }
    }
}

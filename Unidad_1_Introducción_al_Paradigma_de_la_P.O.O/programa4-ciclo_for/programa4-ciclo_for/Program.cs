using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa4_ciclo_for
{
    internal class Program
    {
        static void Main(string[] args)
        {//IMPRIMIR 10 NUMEROS DEL 0 A 9 USANDO UN CICLO FOR
            //DECLARAR VARIABLES
            sbyte i;//declaramos el contador

            //proceso del ciclo for
            for (i = 0; i < 10; i++ )//si el contador sigue siendo menor a 10 seguira el ciclo
            {
                Console.Write(i + ","); //imprime el contador
            }

            Console.Write("\nTERMINO EL PROGRAMA , PRECIONE ENTER PARA CERRAR");
            Console.Read();
        }
    }
}

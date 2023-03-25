using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa10_arreglo_unidimensional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ARRREGLO UNIDEMENCIONAL IMPRIMIR 10 NUMEROS

            //DECLARAR VARIABLES

            sbyte i = 0;//constador

            //Declara arreglo

            sbyte[] numeros = new sbyte[5] {1, 2, 3, 4, 5};
            
            for(i = 0; i < numeros.Length;i++ )//imprimir datos
            {
                Console.WriteLine(numeros[i]);
            }

            Console.Write("PRECIONE ENTER PARA SALIR, SE TERMINO EL PROGRAMA");
            Console.ReadKey();

        }
    }
}

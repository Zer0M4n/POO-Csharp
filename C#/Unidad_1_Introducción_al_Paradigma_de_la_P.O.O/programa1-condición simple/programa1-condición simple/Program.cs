using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace programa1_condición_simple//PROGRAMA DE CONDICION SIMPLE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PROGRAMA PARA SABER QUE NUMERO ES MAYOR USANDO UNA CONDICION SIMPLE

            //INGRESAMOS LOS DATOS

            int numero1 = 0, numero2 = 0;

            //Capturamos los datos 

            Console.Write("Dame el numero 1: ");
            numero1 = Int16.Parse(Console.ReadLine());//Guardamos en la memoria el nuevo valor del numero1

            Console.Write("Dame el numero 2: ");
            numero2 = Int16.Parse(Console.ReadLine());// Guardamos en la memoria el nuevo valor del numero1

            //Procesamos los datos usando una condicional simple

            if(numero1 > numero2) //La condicional indica que si el numero1 es el mayor aparecera el siguiente texto
            {
                Console.Write("El numero {0} es el MAYOR, y el menor es {1}", numero1,numero2);//IMPRIMOS EL NUMERO 1 INDICANDO QUE ES EL MAYOR
            }
            else//en caso que no se cumpla la condicional aprecera los siguiente
            {
                Console.Write("El numero {0} es el MEYOR y el menor {1}",numero2,numero1);//IMPRIMOS EL NUMERO 2 INDICANDO QUE ES EL MAYOR
            }

            Console.WriteLine("\nEl Programa a terminado , PRECIONE ENTER");//Indicamos que el programa a terminado

            Console.ReadKey();//Para el subproceso hasta que se precione enter
            //FIN DEL PROGRAMA

        }
    }
}

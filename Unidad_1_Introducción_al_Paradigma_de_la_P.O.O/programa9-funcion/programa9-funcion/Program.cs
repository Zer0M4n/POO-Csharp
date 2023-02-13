using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa9_funcion
{
    internal class Program
    { 
        static sbyte funcionsuma(sbyte numero1, sbyte numero2)//FUNCION SUMA DE tipo sbyte 
        {
            //PROCESO DE LA SUMA
            sbyte suma = 0;

            suma= (sbyte)(numero1 + numero2);

            return suma;

        }
        static void Main(string[] args)
        {
            //DECLARAR VARIBLES
            sbyte numero1 = 0, numero2 = 0;
             //CAPTURRAR DATOS
            Console.Write("Numero1: ");
            numero1 = sbyte.Parse(Console.ReadLine());

            Console.Write("Numero2: ");
            numero2= sbyte.Parse(Console.ReadLine());
            //IMPRIMIR DATOS
            
            Console.Write("EL RESULTADO ES {0}",funcionsuma(numero1,numero2));

            Console.Write("\nPRECIONE ENTER PARA SALIR");
            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace programa34_practica_Indice_Fuera_Rango
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DECLARAMOS LOS VALORES
            byte i = 0;
            //DECLARAMOS VECTOR
            Random RDM = new Random();
            int[] VECTOR = new int[15];
            //GENERAMOS UN TRY-CATCH-FINALLY
            try
            {
                

                //PROCESO
                //CICLO FOR PARA AGREGAR 10 NUMEROS ALEATARIOS
                for (i = 0; i < VECTOR.Length; i++)
                {
                    VECTOR[i] =  RDM .Next(10,99);
                }
                //ARREGLAMOS EL ARREGLO
                Array.Sort(VECTOR);

                //IMPRIMIMMOS EL VECTOR ORDENADO
                for(i = 0; i < VECTOR.Length; i++) 
                {
                    Console.WriteLine("indice {0}, valor {1} ",i ,VECTOR[i]);

                }
                Console.ReadKey();

                //GENERAMOS UN ERROR CONTROLADO
                VECTOR[15] = 12345;

                

            }
            catch(IndexOutOfRangeException e) 
            {
                Console.WriteLine(e.Message);
                Console.Write("ruta del error : {0}",e.StackTrace);
            }
            finally 
            {
                Console.WriteLine("fin del programa");
                Console.WriteLine("El bloque finally siemore se ejecuta");
                Console.ReadKey();
            }
        }
    }
}

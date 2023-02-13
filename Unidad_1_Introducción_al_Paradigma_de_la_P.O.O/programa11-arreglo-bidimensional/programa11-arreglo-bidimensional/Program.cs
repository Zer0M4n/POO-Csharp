using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INICIALIZAR VALORES

            Console.BackgroundColor = ConsoleColor.Green;
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Black;
            //declara varibles 

            int fila_contador = 0, columna_contador = 0, contador = 0;

            //agregar datos al vectro con la funcion ramdom

            Random numero_random = new Random();

            //declarar vector bidimencional

            int[,] vector_diagonal = new int[4, 4];// fila, columna



            for (fila_contador = 0; fila_contador < 4; fila_contador++)//capturamos para filas
            {

                for (columna_contador = 0; columna_contador < 4; columna_contador++)//capturamos columnas
                {
                    vector_diagonal[fila_contador, columna_contador] = numero_random.Next(35);

                }
            }

            //imprecion de datos del vartor

            for (fila_contador = 0; fila_contador < 4; fila_contador++)
            {


                Console.WriteLine("\n REGLON NUMERO {0}", fila_contador);

                for (columna_contador = 0; columna_contador < 4; columna_contador++)
                {
                    Console.WriteLine("COLUMNANUMERO {0}, CON VALORES {1} ", columna_contador, vector_diagonal[fila_contador, columna_contador]);
                }

                Console.WriteLine("");
            }

            //imprimimos la diagonal

            //relacionamos los vectores con variables CON FOR

            for (fila_contador = 0; fila_contador < 4; fila_contador++)
            {
                for (columna_contador = 0; columna_contador < 4; columna_contador++)
                {
                    if (fila_contador == columna_contador)//Si la fila s y la columna son iguales se almacena en un vector simple llamado diagonal
                    {

                        int[] diagonal = new int[4];
                        diagonal[contador] = vector_diagonal[fila_contador, columna_contador];

                        Console.WriteLine(diagonal[contador] + "");

                    }
                }

            }



            Console.ReadKey();
        }

    }
}

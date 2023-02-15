using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa12_practica_Unidad_1
{

    
    internal class Program
    {
       static int funcionAREA(int lado)//CREAMOS UNA FUNCION PARA EL AREA
        { 
            Int16 Area = 0;//DECLARAMOS LA VARIABLE


            Area = (Int16)Math.Pow(lado,2);

            return  Area; 
        }
        static void AREA()//CREAMOS UN PROCEDMIENTO
        {
            Int16 lado = 0, Area = 0;//DECLARAMOS VARIABLES

            //CAPTURAMOS LOS DAOTS

            Console.Write("VALOR DEL LADO :  ");
            lado = Int16.Parse(Console.ReadLine());

            //IMPRIMIMOS EL AREA 
            Console.WriteLine("El area es {0}", funcionAREA(lado));

        }
        static void Main(string[] args)
        {
            //DECLARAMOS VARIABLES
            Int16 i =0 , multiplos3 = 51,  reglon = 0, columna = 0, SumaMatriz = 0,promedio = 0;
            string opc ;
            

            //MUESTRA EL TEXTO
            Console.Write("QUE DESEA HACER ? " +
                "\n1)Calcular area del grupo \n2)Desplegar multiplos 3 desde el 50 \n3)Suma y promedio con numeros ramdom \n4)salir del programa○\n");
            Console.Write("\nEscribe solo el numero el numero seleccionado: ");
            opc = Console.ReadLine();
            

            //Hacemos un menu con swich cAASE

            switch (opc) 
            {
                case "1":                   
                    //llamamos la funcion con procedimiento
                    AREA();

                    break;

                case "2":
                    
                    for(i = 0; i<16; i++)//del 3 al 50 hay 16 multiplos de 3 por eso el ciclo terminara con 16 iteraciones
                    {
                        multiplos3 = (short)(multiplos3 - 3);//el valor multiplos3 se va restando en 3 en  3 
                        Console.WriteLine(multiplos3);//imprimimos el resultadp
                    }

                    break;

                case "3":

                    Random numeros = new Random();
                    int[,] suma = new int[4,4];

                    //Llenar los numeros aleatorias en la matriz

                    for(reglon= 0; reglon < 4; reglon++)
                    {
                        for(columna = 0; columna < 4; columna++)
                        {
                            suma[reglon, columna] = numeros.Next(9);
                        }
                    }

                    //Imprimir resultados con suma 
                    Console.Write("resultados de la suma\n");
                    for (reglon = 0; reglon < 4; reglon++)
                    {
                        for(columna = 0; columna < 4; columna++)
                        {
                            SumaMatriz = (short)(suma[reglon, columna] + suma[reglon,columna]);

                            
                            Console.WriteLine(SumaMatriz);
                        }
                        
                       
                    }

                    
                    for (reglon = 0; reglon < 4; reglon++)//Sacamos el promedio total
                    {
                        for (columna = 0; columna < 4; columna++)
                        {
                            SumaMatriz += (short)( suma[reglon, columna]); ;//suma total de la matriz

                        }
                    }
                    promedio = (short)(SumaMatriz / 16);
                    Console.Write("PROMEDIO TOTAL ES: {0}", promedio);


                    break;

                case "4":
                    Console.WriteLine("HAZ SALIDO DEL PROGRAMA");
                    break;
            }
            Console.WriteLine("\nFIN DEL PROGRAMA , Precione ENTER PARA SALIR");
            Console.ReadKey();
        }
    }
}

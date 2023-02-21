using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa12_practica_Unidad_1
{

    
    internal class Program
    {
       static int funcionAREA(short lado)//CREAMOS UNA FUNCION PARA EL AREA
        { 
            short Area = 0;//DECLARAMOS LA VARIABLE


            Area = (short)(Math.Pow(lado, 2)*6);

            return  Area; 
        }
        static void AREA()//CREAMOS UN PROCEDMIENTO
        {
            short lado = 0;//DECLARAMOS VARIABLES

            //CAPTURAMOS LOS DAOTS

            Console.Write("VALOR DEL LADO :  ");
            lado = short.Parse(Console.ReadLine());

            //IMPRIMIMOS EL AREA 
            Console.WriteLine("El area es {0}", funcionAREA(lado));

        }
        static void Main(string[] args)
        {
            //DECLARAMOS VARIABLES
            short i =0 , multiplos3 = 51,  reglon = 0, columna = 0, SumaMatriz = 0,promedio = 0  ;
            
            
            char OPC = 'A';
            
            

            //MUESTRA EL TEXTO
            Console.Write("QUE DESEA HACER ? " +
                "\nA)Calcular area del CUBO de lado entero \nB)Desplegar multiplos 3 desde el 50 de manera DECENDENTE \nC)Suma y promedio de una matriz  con numeros ramdom \nD)salir del programa○\n");
            Console.Write("\nEscribe solo LA LETRA el numero seleccionado: ");
            OPC = char.Parse(Console.ReadLine());
            

            //Hacemos un menu con swich cAASE

            switch (OPC) 
            {
                case 'A':                   
                    //llamamos la funcion con procedimiento
                    AREA();

                    break;

                case 'B':
                    Console.WriteLine("Con ciclo for");

                    for(i = 0; i<16; i++)//del 3 al 50 hay 16 multiplos de 3 por eso el ciclo terminara con 16 iteraciones
                    {
                        multiplos3 = (short)(multiplos3 - 3);//el valor multiplos3 se va restando en 3 en  3 
                        Console.WriteLine(multiplos3);//imprimimos el resultadp
                    }

                    Console.WriteLine("\nCon ciclo DO-WHILE\n");
                    multiplos3 = 51;
                    
                    do
                    {
                        multiplos3 =(short) (multiplos3 - 3);
                        Console.WriteLine(multiplos3);//IMPRIMIMOS RESULTADOS
                        
                    } while (multiplos3 > 3);

                    Console.WriteLine("\nCon ciclo WHILE\n");

                    i = 50;
                    while (i > 1) 
                    {
                        i--;
                      if(i % 3 == 0) //MUESTRA LOS RESIDUOS QUE SEAN IGUAL A 0
                        {
                            Console.WriteLine(i);
                        }
                        
                    }

                    break;

                case 'C':

                    Random numeros = new Random();
                    short[,] suma = new short[4,4];

                    //Llenar los numeros aleatorias en la matriz

                    for(reglon= 0; reglon < 4; reglon++)
                    {
                        for(columna = 0; columna < 4; columna++)
                        {
                            suma[reglon, columna] = (short)numeros.Next(1,9);//del 0 al 9
                        }
                    }

                    //Imprimir resultados con suma 
                    Console.Write("resultados de la suma\n");
                    for (reglon = 0; reglon < 4; reglon++)
                    {
                        for(columna = 0; columna < 4; columna++)
                        {
                            SumaMatriz = (short)(suma[reglon, columna] + suma[reglon,columna]);//sumamos la matriz

                            
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
                    promedio = (short)(SumaMatriz / 16);//promedio de la suma total
                    Console.Write("PROMEDIO TOTAL ES: {0}", promedio);


                    break;

                case 'D':
                    Console.WriteLine("HAZ SALIDO DEL PROGRAMA");
                    break;
            }
            Console.WriteLine("\nFIN DEL PROGRAMA , Precione ENTER PARA SALIR");
            Console.ReadKey();
        }
    }
}

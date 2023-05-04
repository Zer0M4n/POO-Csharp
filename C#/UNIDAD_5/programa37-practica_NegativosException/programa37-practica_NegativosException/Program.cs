using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa37_practica_NegativosException
{
    internal class Program
    {
        class NegativeExection : ApplicationException//clase para las exepciones
        {
            //Constructor de la clsae que heredA
            public NegativeExection() : base("No se puede calcular el seno de un numero negativo")
            {
                //VACIO
            }
        }
        static void Main(string[] args)
        {
            //Declaramos Variables
            int opc = 0;
            bool ciclo = true;
            short Angulo = 0;
            double Resultado = 0;


            try
            {
                //Menu
                do
                {
                    Console.WriteLine("Que desea escoger?\n1)Capturar y Calcular Funcion\n2)Salir del programa");
                    opc = int.Parse(Console.ReadLine());
                    switch (opc)
                    {
                        case 1:
                            Console.WriteLine("Ingrese el angulo (Numeros enteros)");
                            Angulo = short.Parse(Console.ReadLine());

                            if (Angulo < 0)
                            {
                                throw new NegativeExection();
                            }
                            else
                            {

                                Resultado = Math.Sin(Angulo);

                                Console.WriteLine("El resultado del seno de angulo {0} es: {1} ", Angulo, Resultado);
                            }

                            Console.WriteLine("Precione enter para Continuar");
                            Console.ReadKey();
                            Console.Clear();
                            break;

                        case 2:
                            Console.WriteLine("Precione enter para salir");
                            Console.ReadKey();
                            Console.Clear();

                            ciclo = false;
                            break;

                        default:
                            Console.WriteLine("Opcion no valida");
                            break;
                    }
                } while (ciclo == true);
            }
            catch (NegativeExection ex) 
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Ruta del error: {0}",ex.StackTrace);
            }
            catch(FormatException n)
            {
                Console.WriteLine(n.Message);
                Console.WriteLine("Ruta del error: {0}", n.StackTrace);
            }
            finally
            {
                Console.WriteLine("\nEl finally siempre se ejecuta.");
                Console.WriteLine("\npresione <enter> para continuar...");
                Console.ReadKey();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa38__practica_EcuacionCuadratica
{
    internal class Program
    {
         class NEGATIVEexeption : ApplicationException
        {
            //Constructor de la clase
            public NEGATIVEexeption(): base("La Ecuación Cuadrática NO tiene Solución!!!")
                
                {

                }
        }
        static void Main(string[] args)
        {
            //Declaracion de variables
            int a = 0, b = 0, c = 0, D = 0;
            int X1 = 0, X2 = 0;
            char opc = 's';
            bool cilce = true;
            try
            {
                //CICLO
                do
                {
                    switch (opc)
                    {
                        case 'A':
                            Console.Write("Dame el numero a: ");
                            a = int.Parse(Console.ReadLine());

                            Console.Write("Dame el numero b: ");
                            b = int.Parse(Console.ReadLine());

                            Console.Write("Dame el numero c: ");
                            c = int.Parse(Console.ReadLine());

                            D = (int)(Math.Pow(b, 2) - 4 * a * c);

                            if (D < 0)
                            {
                                throw new NEGATIVEexeption();


                            }
                            else
                            {
                                X1 = (int)(-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c) / 2 * a);
                                X2 = (int)(-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c) / 2 * a);

                                Console.WriteLine("El valor de X1 es: {0}", X1);
                                Console.WriteLine("El valor de X2 es: {0}", X2);
                            }
                            break;
                        case 'B':
                            Console.WriteLine("Programa terminado, precione enter");
                            cilce = false;
                            Console.ReadKey();
                            break;
                        default:
                            Console.WriteLine("Opcion no valida");
                            break;
                    }
                } while (cilce == true);
                
                
            }
            catch (NEGATIVEexeption Z) 
            {
                Console.WriteLine("ERROR ; {0}", Z.Message);
                Console.WriteLine("RUTA DEL ERROR: {0}",Z.StackTrace);
            }
            catch(FormatException n)
            {
                Console.WriteLine("ERROR ; {0}", n.Message);
                Console.WriteLine("RUTA DEL ERROR: {0}",n.StackTrace);
            }
            finally 
            { 
                Console.WriteLine("“Programa desarrollado por: CESAR GONZALEZ SALAZAR\nNO: 22211575”");
                Console.WriteLine("Materia: Programacion orientada a objetos");

                Console.ReadKey();
            }
        }
    }
}

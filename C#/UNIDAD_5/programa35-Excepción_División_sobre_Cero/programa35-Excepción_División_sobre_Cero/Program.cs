using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace programa35_Excepción_División_sobre_Cero
{
    internal class Program
    {
        static float divide(float a, float b)//funcion con la que vamos adividir
        {
            if (b == 0) //En el caso que sea 0 lanzamos una excepción
            {
                throw new DivideByZeroException();//execipon de division por 0
            }
            else
            {
                return a / b;//retornal el valor usando division
            }
        }
        static void Main(string[] args)
        {
            //declaramos variables
            float a = 0, b = 0 , RESULTADO = 0;

            try
            {
                //Capturamos datos
                Console.Write("Introduce el primer número: ");
                a = float.Parse(Console.ReadLine());

                Console.Write("Introduce el segundo número: ");
                b = float.Parse(Console.ReadLine());

                RESULTADO = divide(a, b);//llammamos ala funcion

                Console.WriteLine("El resultado de la división es: {0}", RESULTADO);//IMPRIMIMOS LA DIVICION
            }
            catch(DivideByZeroException m)//EN CASO QUE SE DIVIDA EN 0 SE LLAMAN ESTOS MENSAJE
            {
                Console.WriteLine(m.Message);//MENSAJE DE ERROR
                Console.WriteLine(m.StackTrace);//RUTA DE ERROR
            }
            catch(FormatException T)
            {
                Console.WriteLine(T.Message);
                Console.WriteLine(T.StackTrace);
            }
            finally//BLOQUE FINALLY
            {
                Console.WriteLine("EL BLOQUE FINALLY SIEMPRE SE EJCUTA");
                Console.WriteLine("Fin del programa precione enter");
                Console.ReadKey();

            }
        }
    }
}

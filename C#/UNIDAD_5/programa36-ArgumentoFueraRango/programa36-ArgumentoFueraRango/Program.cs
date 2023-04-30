using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa36_ArgumentoFueraRango
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DECLARAR VARIABLES
            int BASE = 0;
            int Resulatdo = 0;

            try
            {
                Console.Write("NUMERO :");
                BASE = int.Parse(Console.ReadLine());

                if(BASE <= 999)
                {
                    Resulatdo = (int)Math.Pow(BASE, 5);
                    Console.WriteLine("RESULTADO : {0}", Resulatdo);
                }
                else { throw new ArgumentOutOfRangeException(); }
            }
            catch (FormatException e) 
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Ruta del error " + e.StackTrace);
            }
            catch( ArgumentOutOfRangeException n)
            {
                Console.WriteLine(n.Message);
                Console.WriteLine("Ruta del error " + n.StackTrace);
            }
            finally
            {
                Console.WriteLine("El bloque finally siempre se ejecuta");
            }
            Console.WriteLine("Precione enter para continuar");
            Console.ReadKey();
        }
    }
}

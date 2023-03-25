using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace programa19_sobrecarga_de_operadores
{
    internal class Program
    {
        public class NumerosImaginarios
        {
            //Campo de la clase
            public float real = 0f, imaginario = 0f;

            //Constructor de la clase
            public NumerosImaginarios(float real, float imaginario)
            {
                this.real = real;
                this.imaginario = imaginario;
            }

            //sobrecarga de operador binario * multiplicacion

            public static NumerosImaginarios operator *(NumerosImaginarios c1 , NumerosImaginarios c2)
            {
                return new NumerosImaginarios(c1.real*c2.real, c1.imaginario*c2.imaginario);
            }

            //sobrecarga de operador binario - resta

            public static NumerosImaginarios operator -(NumerosImaginarios c1, NumerosImaginarios c2)
            {
                return new NumerosImaginarios(c1.real - c2.real , c1.imaginario - c2.imaginario);
            }

            //sobrecarga de operador binario  + suma
            public static NumerosImaginarios operator +(NumerosImaginarios c1 , NumerosImaginarios c2)
            {
                return new NumerosImaginarios(c1.real + c2.real , c1.imaginario+c2.imaginario);
            }

            //Sobrecarga de opredor / division

            public static NumerosImaginarios operator /(NumerosImaginarios c1 , NumerosImaginarios c2)
            {
                return new NumerosImaginarios(c1.real / c2.real, c1.imaginario / c2.imaginario);
            }

            //sobrecarga de ++ (acumulador)
            public static NumerosImaginarios operator ++(NumerosImaginarios c1)
            {
                return new NumerosImaginarios (c1.real +1, c1.imaginario +1);
            }
            //sobrecarga de --
            public static NumerosImaginarios operator --(NumerosImaginarios c1)
            {
                return new NumerosImaginarios(c1.real -1, c1.imaginario -1);
            }

            //Mostrar el resultado

            public override String ToString()//Resulatdo de operaciones basicas +-*/
            {
                return (String.Format ("{0} + {1}i ",real,imaginario));
            }
           

            //DESTRUCTOR DE LA CLASE
            ~NumerosImaginarios() { Console.Write("Memroria LIberada"); }

        }
        static void Main(string[] args)
        {
            //declarar variables
            float num1 = 0f , num2 = 0f, num3 = 0f, num4 = 0f;
            //Capturar objetos

            Console.Write("Numero 1: ");
            num1 = float.Parse(Console.ReadLine());

            Console.Write("Numero 2: ");
            num2= float.Parse(Console.ReadLine());

            Console.Write("Numero 3: ");
            num3 = float.Parse(Console.ReadLine());

            Console.Write("Numero 4: ");
            num4 = float.Parse(Console.ReadLine());

            //Creacion y asignacion de objeto
            NumerosImaginarios c1 = new NumerosImaginarios(num1,num2);
            NumerosImaginarios c2 = new NumerosImaginarios(num3,num4);

            NumerosImaginarios incremento = new NumerosImaginarios(num1,num2);
            NumerosImaginarios decremento = new NumerosImaginarios(num1, num2);


            //LLama ala sobrecarga del operador suma , resta , multiplicacin, division

            NumerosImaginarios suma = c1 + c2;
            NumerosImaginarios resta = c1 - c2;
            NumerosImaginarios multiplicacion = c1 * c2;

            incremento++;
            decremento--;

            //Mostramos los numeros y la suma usando el metos tostrin

            Console.WriteLine("Primer numero complejo {0}",c1);
            Console.WriteLine("Segundo numero complejo {0}",c2);
            Console.WriteLine("Suma de los dos numeros complejos {0}",suma);
            Console.WriteLine("Resta de los dos numeros complejos {0}", resta);
            Console.WriteLine("multiplicacion de los dos numeros complejos {0}", multiplicacion);

            Console.WriteLine("EL INCREMENTO DE UN NUMERO COMPLEJO: {0}",incremento);
            Console.WriteLine("EL DECREMENTO DE UN NUMERO COMPLEJO {0}",decremento);

           

            Console.WriteLine("PRECIONE ENTER PARA SALIR");
            Console.ReadLine();

        }
    }
}

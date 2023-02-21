using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa13_clase_Rectángulo
{
    internal class Program
    {
        public class RECTANGULO// CLASE RECTANGULO
        {
            //DECLARAR LOS CAMPOS DEL RECTANGULO
            float BASE = 0f, Altura = 0f;

            public RECTANGULO(float b, float a)//CONSTRUCTOR DE LA CLASE
            {
                BASE = b;
                Altura = a;
            }

            public float AREA()//FUNCION AREA
            {
                //DEclararr campos

                float AREA = 0f;

                AREA = (float)(BASE * Altura);
                return AREA;
            }

            public float Perimetro()//funcion perimetro
            {
                float PERIMETRO = 0f;

                PERIMETRO = (float)((BASE + Altura)*2);

                return PERIMETRO;
            }
            ~RECTANGULO()//El destructor libera  la memoria de la 
            {
                Console.WriteLine("MEMORIA LIBERADA DEL LA CLASS RECTANGULO");
            }
        }
       
        static void Main(string[] args)
        {
            //inicialiar  valores
            float b = 0f, a = 0f; 
            
            //Cpaturamos los datos 
            Console.Write("BASE : ");
            b = Single.Parse(Console.ReadLine());

            Console.Write("altura : ");
            a = Single.Parse(Console.ReadLine());

            RECTANGULO rectangulo = new RECTANGULO( a , b);

            //DESPLEGAR RESULTADOS


            rectangulo.AREA();//uCreamos un objeto
            rectangulo.Perimetro();//cREAMOS OBJETO

            Console.Write("\nBase es {0} y perimetro {1}\n", rectangulo.AREA(),rectangulo.Perimetro());

            Console.WriteLine("PRECIONE ENTER");
            Console.ReadKey();




        }
    }
}

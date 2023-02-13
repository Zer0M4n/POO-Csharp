using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa2_condición_compuesta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programa que calcula el promedio y te muestra si estas aprobado o reprobado, usaremos una condicional compuesta

            //Declarar variables
            
            short Materia1 = 0, Materia2 = 0, Materia3 = 0, Promedio = 0, semestre = 0;//usamos short
            string Numero_Control = "", Nombre_Usuario = "";
             

            //capturamos los datos
            Console.Write("Nombre completo: ");
            Nombre_Usuario = Console.ReadLine();

            Console.Write("Numero de control: ");
            Numero_Control= Console.ReadLine();//Capturamos la variable de tipo string

            Console.Write("Calificacion de la materia 1: ");
            Materia1 = short.Parse(Console.ReadLine());//Guardamos la variable

            Console.Write("Calificacion de la materia 2: ");
            Materia2 = short.Parse(Console.ReadLine());

            Console.Write("Calificacion de la materia 3: ");
            Materia3 = short.Parse(Console.ReadLine());

            Console.Write("Semestre: ");
            semestre = short.Parse(Console.ReadLine());

            //Proceso de datos

            Promedio = ((short)((Materia1 + Materia2 + Materia3) / 3));

            //PROCESO SE LA CONDICIONAL COMPUESTA
            if(Promedio >= 90 && semestre >= 5)
            {
                Console.Write("Estudiante {0} , del semestre {1}, con el promedio {2}, eres admiritorio de beca", Nombre_Usuario,semestre,Promedio);
            }
            else if(Promedio >= 70 && semestre < 5)
            {
                Console.Write("Estudiante {0} , del semestre {1}, con el promedio {2}, eres no admiritorio de beca ", Nombre_Usuario, semestre, Promedio);
            }
            else
            {
                Console.Write("REPROBASTE , eres no admiritorio de beca");
            }

            Console.WriteLine("\nPrecione ENTER para terminar el programa");

            Console.ReadKey();//Detiene los subprocesos hasta que se precione enter

        }
    }
}

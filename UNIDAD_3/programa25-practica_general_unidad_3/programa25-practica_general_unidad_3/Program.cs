using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa25_practica_general_unidad_3
{
    internal class Program
    {
        class Funciones_Matematicas
        {
            //Campos de la clase
            public float Angulo = 0f;

            //Constructor de la clase
            public Funciones_Matematicas(float Angulo ) 
            {
                this.Angulo = Angulo;
            }

            //Metodos de la clase
            public  virtual double CalcularFuncion()
            {
                return 0;
            }
            public void DesplegarFuncion()
            {

            }

            ~Funciones_Matematicas() { Console.WriteLine("Memoria liberada de la clase Funciones matematicas"); }

        }

        class Seno : Funciones_Matematicas
        {
            //Constructor de la clase
            public Seno(float Angulo): base( Angulo) 
            {

            }
            //Metodos de la clase
            public  override double CalcularFuncion()
            { return (double)(Math.Sin(Angulo)); }

            public new void DesplegarFuncion()
            {
                Console.WriteLine("-----------------SENO-----------------");
                Console.Write("EL valor del angulo: {0}\nEL valor del seno es {1}",Angulo,CalcularFuncion());

                Console.WriteLine("\nPrecione de ENTER para seguir");
                Console.ReadKey();
                Console.Clear();

            }

            ~Seno() { Console.WriteLine("Memoria liberada de la clase Seno"); }
        }

        class Coseno : Funciones_Matematicas
        {
            //Constructor de la clase
            public Coseno(float Angulo): base( Angulo) { }

            //Metodos de la clase
            public override double CalcularFuncion()
            { return (double)(Math.Cos(Angulo)); }

            public new void DesplegarFuncion()
            {
                Console.WriteLine("-----------------COSENO-----------------");
                Console.Write("\nEL valor del angulo: {0}\nEL valor del Coseno es  {1}",Angulo,CalcularFuncion());

                Console.WriteLine("\nPrecione de ENTER para seguir");
                Console.ReadKey();
                Console.Clear();

            }
            //Destructor de la clase
            ~Coseno() { Console.WriteLine("Memoria liberada de la clase Coseno"); }
            
        }
        class Tangente : Funciones_Matematicas 
        {
            //Constructor de la clase
            public Tangente(float Angulo): base( Angulo) { }
            //Metodos de la clase
            public override double CalcularFuncion() { return (double)(Math.Tan(Angulo)); }

            public new void DesplegarFuncion() 
            {
                Console.WriteLine("-----------------TANGENTE-----------------");
                Console.Write("EL valor del angulo: {0}\nEL valor del tangente es {1}", Angulo, CalcularFuncion());

                Console.WriteLine("\nPrecione de ENTER para seguir");
                Console.ReadKey();
                Console.Clear();

            }

            //DESTRUCTOR DE LA CLASE
            ~Tangente() { Console.WriteLine("Memoria liberada de la clase Tangente"); }
        }
        static void Main(string[] args)
        {
            //DECLARAR VARIABLES
            float Angulo = 0f;

            //Capturar datos

            Console.Write("Cual es el Angulo?  ");
            Angulo = float.Parse(Console.ReadLine());

            //Crear objetos
            Seno sin = new Seno(Angulo);
            Coseno cos = new Coseno(Angulo);
            Tangente tan = new Tangente(Angulo);

            //llamar metodos

            sin.DesplegarFuncion();
            cos.DesplegarFuncion();
            tan.DesplegarFuncion();

            Console.WriteLine("Precione enter para salir");
            Console.ReadKey();

        }
    }
}

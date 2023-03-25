using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa17_clase_círculo
{
    internal class Program
    {
        class Circulo//calase circulo
        {
            //Campos de la clase
            private float radio = 0f;

            //Constructor de la clase
            public Circulo(float radio) 
            {
                this.radio = radio;//USAMOS THSI
            }
            public Circulo() { Console.WriteLine("Objeto circulo creado sin datos"); }//constructor sin datos


            //Metodos de la clase
            public double CalcularAREA(float radio)//Funcion Area
            {
                return (double)(Math.PI*Math.Pow(radio,2));//Returna el valor a la funciom
            }
            public double CalcularPerimetro(float radio)//Funcion perimetro
            {
                return (double)(2*Math.PI*radio);//Returna el valor a la funciom
            }
            public void DesplegarDatos()//PROCEDIMIENTO PARA DESPLEGAR DATOS
            {
                Console.Write("AREA: {0}",CalcularAREA(radio));
                Console.Write("\nPERIMETRO: {0}", CalcularPerimetro(radio));
            }
            //Destructor de la clase
            ~Circulo() { Console.Write("\nMemoria ha sido liberada de la clase circulo\n"); }
        }
        static void Main(string[] args)
        {
            //Inicializar valores

            float radio = 0f;

            //Capturar datos

            Console.Write("CUAL ES SU RADIO?  ");
                radio = float.Parse(Console.ReadLine());

            //Creacion del objeto
            Circulo circulo1 = new Circulo();
            Circulo circulo2 = new Circulo(radio);

            //LLAMR METODOS

            circulo2.DesplegarDatos();
            

            Console.Write("\nPrecione ENTER para salir");
            Console.ReadKey();

        }
    }
}

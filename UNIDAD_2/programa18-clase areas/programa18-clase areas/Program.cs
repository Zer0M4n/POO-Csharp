using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa18_clase_areas
{
    internal class Program
    {
        public class AREA//clase AREA
        {
            string NOMBRE="";//METODO DE LA CLASSE

            public AREA (string NOMBRE)//CONSTRUCTOR DE LA CLASE
            {
             this.NOMBRE = NOMBRE;//CAMPOS DE LA CLASE
            }

            public double AREA_CUADRADO(double lado)//FUNCION PARA CALCULAR AERA
            {
                return Math.Pow(lado, 2);//NOS RETORNA EL VALOR
            }

            public float AREA_RECTANGULO(float largo   , float ancho)//FUNCION DE CLACULAR AERA RECTANGULO
            {
                return largo * ancho;//NOS RETORNA EL VALOR
            }

            public void DESPLEGARAREA (double AREA)//FUNCION PROCEDIMIENTO
            {
                Console.WriteLine("NOMBRE DE LA FIGURA {0}, EL AREA ES {1}  ", NOMBRE,AREA);//IMPRESION
            }
            ~AREA()//DESTRUCTOR DE LA CLASE
            {Console.WriteLine("Objeto Destruido: {0} " , NOMBRE);}
        }
        static void Main(string[] args)
        {
            string NOMBRE = "";
            double lado = 0;
            float largo = 0, ancho = 0;

           //CAPTURAMOS DATOS DEL CUADRADO
            Console.Write("CUAL ES EL NOMBRE DE LA FIGURA: ");
            NOMBRE = Console.ReadLine();

            Console.Write("CUANTO MIDE EL LADO DEL CUADRADO: ");
            lado = double.Parse(Console.ReadLine());
            
            AREA CUADRADO = new AREA(NOMBRE);//CONSTRUCTOR DEL OBJETO Cuadrado

            CUADRADO.DESPLEGARAREA(CUADRADO.AREA_CUADRADO(lado));//DESPLEGAR LOS DATOS

            Console.Write("Precione ENTER para continuar");
            Console.ReadKey();
            Console.Clear();//Limpiamos pantalla despues de que precione neter

            //Cpaturamos la datos del rectangulo
            Console.Write("CUAL ES EL NOMBRE DE LA FIGURA: ");
            NOMBRE = Console.ReadLine();
            Console.Write("CUANTO MIDE EL LARGO DEL RECTANGULO: ");
            largo = float.Parse(Console.ReadLine());
            Console.Write("CUANTO MIDE EL ANCHO DEL RECTANGULO: ");
            ancho = float.Parse(Console.ReadLine());
           
            AREA RECTANGULO = new AREA(NOMBRE);//CONSTRUCTOR DEL OBJETO RECTANGULO


            RECTANGULO.DESPLEGARAREA(RECTANGULO.AREA_RECTANGULO(largo,ancho));//DESPLEGAR LOS DATOS

            Console.WriteLine("PRESIONE ENTER PARA SALIR");
            Console.ReadKey();
        }
    }
}

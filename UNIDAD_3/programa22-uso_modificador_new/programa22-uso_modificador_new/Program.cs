using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa22_uso_modificador_new
{
    internal class Program
    {
        class Rectangulos
        {
            //CAMPOS DE LA CLASE
            public float LARGO = 0f, ANCHO = 0f;
            
            //coNSTRUCTOR DE LA CLASE
            public Rectangulos(float LARGO,float ANCHO) 
            {
                this.LARGO = LARGO;
                this.ANCHO = ANCHO;
            }

            //METODOS DE LA CLASE

            public void AREA()
            {
                float AREA = 0f;

                AREA = LARGO * ANCHO;

                Console.WriteLine("El area del rectangulo: {0}", AREA);
            }
            public void Perimetro()
            {
                float perimmetro = 0f;

                perimmetro = 2 * (LARGO + ANCHO);

                Console.WriteLine("El perimetro es {0}",perimmetro);
            }

            //Destructor de la clase
            ~Rectangulos() { Console.Write("Memoria liberada de la clase rectangulo"); }

        }
        class Cuadrado: Rectangulos
        {
            //Constructor de la clase

            new float LARGO = 0f;

            public Cuadrado(float LARGO,float ANCHO): base (LARGO,ANCHO)
            {
               this.LARGO = LARGO;
            }
            public new void AREA()
            {
                float AREA = 0f;

                AREA = (float)Math.Pow(LARGO,2);

                Console.Write("\nEl area del cuadrado es {0}", AREA);

            }
            public new void  Perimetro()
            {
                float perimetro = 0f;

                perimetro = 4 * LARGO;

                Console.Write("\nEl perimetro es {0}", perimetro);
            }

            //DESTRUCTOR DE LA CLASE
            ~Cuadrado() { Console.Write(""); }
        }
        static void Main(string[] args)
        {
            //Declarar variables

            float LARGO = 0f, ANCHO = 0f;

            //CAPTURAR DATOS RECTANGULO

            Console.Write("Largo:  ");
            LARGO = float.Parse(Console.ReadLine());

            
            Console.Write("Ancho: ");
            ANCHO = float.Parse(Console.ReadLine());
            //OBJETOS RECTANGULOS
            Rectangulos RECT = new Rectangulos(LARGO, ANCHO);

            RECT.AREA();
            RECT.Perimetro();

            Console.ReadKey();
            Console.Clear();

            //Capturar datos del cuadrado
            Console.Write("Largo:  ");
            LARGO = float.Parse(Console.ReadLine());

            //oBJETO DEL CUADRADO

            Cuadrado CUADR = new Cuadrado(LARGO,ANCHO);    

            CUADR.AREA();
            CUADR.Perimetro();

            Console.Write("\nPreciona Enter par salir");
            Console.ReadKey();


        }
    }
}

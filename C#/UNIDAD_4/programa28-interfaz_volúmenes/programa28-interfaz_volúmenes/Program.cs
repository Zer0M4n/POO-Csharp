using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa28_interfaz_volúmenes
{
    internal class Program
    {
         interface  IFigura//Hacemos la interface
        {
            //METODOS DE LA CLASE
            double CalcularVolumen();
            void desplegarVolumen(double resultado);

        }
        //Clase DERIVADA 1
        class Esfera : IFigura
        {
            //CAMPO DE LA CLASE
            private double radio;
            //CONSTRUCTOR DE LA CLASE
            public Esfera(double radio)
            {
                this.radio = radio;
            }
            //METODOS DE LA CLASE
            public double CalcularVolumen()
            {
                return (4.0 / 3.0) * Math.PI * Math.Pow(radio, 3);
            }
            public void desplegarVolumen(double resultado)
            {
                Console.WriteLine("---------------ESFERA---------------");
                Console.WriteLine("El radio es {0}", radio);
                Console.WriteLine("El volumen de la esfera es: {0}", resultado);


                Console.WriteLine("PRECIONE ENTER PARA CONTINUAR");
                Console.ReadKey();
                Console.Clear();
            }
            //DESTRUCTOR DE LA CLASE ~
            ~Esfera() { Console.WriteLine("Se libero la clase Esfera"); }
        }
        //CLASE DERIVADA 2
        class Cubo : IFigura 
        {
            //Campos de la clase
            public float lado;

            //Consttructor de la clase

            public Cubo(float lado) 
            {
                this.lado = lado; 
            }

            //Metodos de la clase
            public double CalcularVolumen()
            {
                
                return Math.Pow(lado, 3);
            }
            public void desplegarVolumen(double resultado)
            {
                Console.WriteLine("---------------CUBO---------------");
                Console.WriteLine("El radio es {0}", lado);
                Console.WriteLine("El volumen de la esfera es: {0}", resultado);

                Console.WriteLine("PRECIONE ENTER PARA CONTINUAR");
                Console.ReadKey();
                Console.Clear();
            }
            //Destructor de la clase
            ~Cubo() { Console.WriteLine("Memoria liberada de la clase Cubo"); }

        }
        //Clase derivada 3
        class Cilindro : IFigura
        {
            //Campos de la clase
            public float radio , Altura;

            //Constructor de la clase
            public Cilindro ( float radio , float Altura )
            {
                this.radio = radio;
                this.Altura = Altura;
            }
            //Metodos de la clase
            public double CalcularVolumen()
            {
                return (double)(Math.PI * Math.Pow(radio, 2) * Altura);
            }
            public void desplegarVolumen(double resultado)
            {
                Console.WriteLine("---------------Cilindro---------------");
                Console.WriteLine("El radio es {0} y la altura es {0}", radio, Altura);
                Console.WriteLine("El volumen del Cilindro es: {0}", resultado);

                Console.WriteLine("PRECIONE ENTER PARA CONTINUAR");
                Console.ReadKey();
                Console.Clear();
            }
            //Destructor de la clase
            ~Cilindro() { Console.WriteLine("Memoria liberada de la clase Cilindro"); }
        }
        //Clase derivada 4
        class Cono : IFigura 
        {
            //CAMPOS DE LA CLASE
            public float radio , Altura;

            //Constructor de la clase
            public Cono( float radio , float Altura ) 
            {
                this.radio = radio;
                this.Altura = Altura;
            }
            //Metodos de la clase
            public double CalcularVolumen()
            {
                return (1.0 / 3.0) * Math.PI * Math.Pow(radio, 2) * Altura; ;
            }
            public void desplegarVolumen(double resultado)
            {
                Console.WriteLine("---------------CONO---------------");
                Console.WriteLine("El radio es {0} Y la Altura es {1}", radio, Altura);
                Console.WriteLine("El volumen de la esfera es: {0}", resultado);

                Console.WriteLine("PRECIONE ENTER PARA CONTINUAR");
                Console.ReadKey();
                Console.Clear();
            }
            //Destructor de la clase
            ~Cono() { Console.WriteLine("Memoria liberada de la clase CONO"); }
        }
        static void Main(string[] args)
        {
            //Declarar variables
            float radio,Altura, lado;
            double resultado;


            //CAPTURAR LOS DATOS DE LA ESFERA

            Console.Write("Radio :  ");
            radio = float.Parse(Console.ReadLine());

            //Constructor de la clase
            Esfera esfera = new Esfera(radio);

            //Damos valor al resultado
            resultado = esfera.CalcularVolumen();
            //Desplegar metodo
            esfera.desplegarVolumen(resultado);
            
            

            //CAPTURAR LOS DATOS DE LA CUBO
            Console.Write("Lado :  ");
            lado = float.Parse(Console.ReadLine());

            //Constructor del objeto
            Cubo cub = new Cubo(radio);

            //Damos valor al resultado
            resultado = cub.CalcularVolumen();

            //Desplegar metodo
            cub.desplegarVolumen(resultado);



            //CAPTURAR LOS DATOS DE LA CILINDRO
            Console.Write("Radio:  ");
            radio = float.Parse(Console.ReadLine());

            Console.Write("Altura:  ");
            Altura = float.Parse(Console.ReadLine());

            //Constructor del cilindro
            Cilindro cil = new Cilindro(radio, Altura);

            //Damos valor al resultado
            resultado = cil.CalcularVolumen();

            //Desplegar metodo
            cil.desplegarVolumen(resultado);


            //CAPTURAR LOS DATOS DE LA CONO
            Console.Write("Radio:  ");
            radio = float.Parse(Console.ReadLine());

            Console.Write("Altura:  ");
            Altura = float.Parse(Console.ReadLine());

            //Constructor de la clase Cono
            Cono con = new Cono(radio, Altura);

            //Damos valor el resultado
            resultado = con.CalcularVolumen();
            //Imprimimoe el metodo
            con.desplegarVolumen(resultado);

           Console.WriteLine("\n\nPRECIONE ENTER PARA CONTINUAR");
           Console.ReadKey();
            
        }
    }
}

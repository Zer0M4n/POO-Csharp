using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static programa_27_clase_abstracta_volúmenes.Program;

namespace programa_27_clase_abstracta_volúmenes
{
    internal class Program
    {
        //Creacion de la clase abstracta
        public abstract class Figura
        {
            // atributos – campos
            public float radio, altura, lado;
            public double volumen;
            // métodos
            abstract public double calcularVolumen();
            abstract public void desplegarVolumen();
            //destructor
            ~Figura()
            {
                Console.WriteLine("Memoria Objeto Clase Abstracta Figuras Liberada");
            }
        }
        //Clase derivada uno
        class Esfera : Figura
        {
            //Constructor
            public Esfera(float radio)
            {
                this.radio = radio;
            }
            public override double calcularVolumen()
            {
                volumen = (double)((4 / 3) * Math.PI * Math.Pow(radio, 3));
                return volumen;
            }
            public override void desplegarVolumen()
            {
                Console.WriteLine("---------------ESFERA---------------");
                Console.WriteLine("Volumen del esfera {0}", calcularVolumen());
                Console.WriteLine("Preciona ENTER para continuar");
                Console.ReadKey();
                Console.Clear();
            }
        }
        //Clase derivada 2
        class Cubo: Figura
        {
            //Constructor de la clase
            public Cubo(float lado)
            {
                this.lado = lado;
            }
            //Metodos de la clase
            public override  double calcularVolumen()
            {
                volumen = (double)(Math.Pow(lado, 3));
                    return volumen;
            }
            public override void desplegarVolumen()

            {
                Console.WriteLine("---------------CUBO---------------");
                Console.WriteLine("Volumen del cubo {0}",calcularVolumen());
                Console.WriteLine("Preciona ENTER para continuar");
                Console.ReadKey();
                Console.Clear();
            }
            //Destructor de la clase
            ~Cubo()
            {
                Console.WriteLine("Memoria Liberada de La clase Cubo");
            }
        }

        //Clase derivada 3
        class Cilindro
        {
            //Campos de la clase
            public float radio, altura;

            //Constructor de la clase
            public Cilindro(float radio, float altura)
            {
                this.radio = radio;
                this.altura = altura;
            }
            //Metodos de la clase
            public  double CalcularVolumen()
            {
                return (double)(Math.PI*Math.Pow(radio,2)*altura) ;
            }
            public  void DesplegarVolumen()
            {

                Console.WriteLine("---------------CILINDRO---------------");
                Console.WriteLine("Volumen del cilindro {0}", CalcularVolumen());
                Console.WriteLine("Preciona ENTER para continuar");
                Console.ReadKey();
                Console.Clear();
            }
            //Destructor de la clase
            ~Cilindro()
            {
                Console.WriteLine("Memoria Liberada de La clase Cilindro");
            }
        }
        //Clase derivada 4
        class Cono
        {
            //campos de la clase
            public float radio, altura;

            //Constructor de la clase
            public Cono(float radio, float altura)
            {
                this.radio = radio;
                this.altura = altura;
            }
            //Metodos de la clase
            public  double CalcularVolumen()
            {
                return (double)((1 / 3f) * Math.PI * Math.Pow(radio, 2) * altura); ;
            }
            public  void DesplegarVolumen()
            {

                Console.WriteLine("---------------CONO---------------");
                Console.WriteLine("Volumen del CONO {0}", CalcularVolumen());
                Console.WriteLine("Preciona ENTER para continuar");
                Console.ReadKey();
                Console.Clear();
            }
            //Destructor de la clase
            ~Cono()
            {
                Console.WriteLine("Memoria Liberada de La clase Cono");
            }
        }
        static void Main(string[] args)
        {
            //Declarar variables
            float radio, altura, lado;

            //Capturar los datos de la esfera
            Console.WriteLine("---------------DATOS DE LA ESFERA---------------");
            Console.Write("RADIO: ");
            radio = float.Parse(Console.ReadLine());

            //OBJETO DE LA CLASE CILINDRO
            Esfera esfera = new Esfera(radio);

            //IMPRIMIR ESFERA

            esfera.desplegarVolumen();

            //Capturar los datos del cubo
            Console.WriteLine("---------------DATOS DEL CUBO---------------");
            Console.Write("Lado:  ");
            lado = float.Parse(Console.ReadLine());

            //Constructor de la clase cubo
            Cubo cubo = new Cubo(lado);

            //Imprimir cubo
            cubo.desplegarVolumen();

            //Capturar los datos del cilindro
            Console.WriteLine("---------------DATOS DEL CILINDRO---------------");
            Console.Write("Radio:  ");
            radio = float.Parse(Console.ReadLine());
            Console.Write("Altura:  ");
            altura = float.Parse(Console.ReadLine());

            //Constructor de la clase cilindro
            Cilindro cilindro = new Cilindro(radio, altura);

            //Imprimir cilindro
            cilindro.DesplegarVolumen();

            //Capturar los datos del cono
            Console.WriteLine("---------------DATOS DEL CONO---------------");
            Console.Write("Radio:  ");
            radio = float.Parse(Console.ReadLine());
            Console.Write("Altura:  ");
            altura = float.Parse(Console.ReadLine());

            //Constructor de la clase cono
            Cono cono = new Cono(radio, altura);

            //Imprimir cono
            cono.DesplegarVolumen();

            Console.WriteLine("Preciona ENTER para salir del programa");
            Console.ReadKey();

        }
    }
}

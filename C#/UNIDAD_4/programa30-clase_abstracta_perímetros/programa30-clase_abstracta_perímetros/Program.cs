using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa30_clase_abstracta_perímetros
{
    internal class Program
    {
        abstract public class Perimetro//Clase abstracta del Perimetro
        {
            //Campos de la clase
            public float Lado = 0,Base = 0, Altura = 0, NumeroLados = 0;

            //Metodos de la clase
            abstract public double CalcularPerimetro();

            abstract public void DesplegarPerimetro();
            //Desrructor de la clase
            ~Perimetro() { Console.WriteLine("Memoria liberada de la clase abstracta"); }
        }

        //Clase rombo
        public class rombo : Perimetro
        {
            //Constructo de la clase
            public rombo(float Lado) { this.Lado = Lado; }
            //Metodos de la clase
            public override double CalcularPerimetro()
            {
                return 4 * Lado;
            }
            public override void DesplegarPerimetro()
            {

                Console.WriteLine("--------------Rombo--------------");
                Console.WriteLine("Lado mide {0}", Lado);
                Console.WriteLine("Perimetro: {0}", CalcularPerimetro());

                Console.WriteLine("Precione ENTER para salir");
                Console.ReadKey();
                Console.Clear();
            }
            //Destructor de la clase
            ~rombo() { Console.WriteLine("Memoria liberada de la clase rombo"); }
        }
        //Clase Romboide
        public class romboide : Perimetro
        {
            //Constructor de la clase
            public romboide(float Base , float Altura) 
            {
                this.Base = Base;
                this.Altura = Altura;
            }

            //Metodos de la clase
            public override void DesplegarPerimetro()
            {

                Console.WriteLine("--------------Romboide--------------");
                Console.WriteLine("Base: {0}\nAltura: {1}", Base, Altura);
                Console.WriteLine("Perimetro: {0}", CalcularPerimetro());

                Console.WriteLine("Precione ENTER para salir");
                Console.ReadKey();
                Console.Clear();
            }
            public override double CalcularPerimetro()
            {
                return (2*Base) + (2*Altura);
            }
            ~romboide() { Console.WriteLine("Memria liberada de la clase romboide"); }
        }
        //Clase
        public class PoligonoRegular : Perimetro
        {
            //Constructor de la clase
            public PoligonoRegular(float Lado, float NumeroLados) 
            {
                this.Lado = Lado;
                this.NumeroLados = NumeroLados;
            }
            //Metodos de la clase
            public override void DesplegarPerimetro()
            {
                Console.WriteLine("--------------Poligono Regular--------------");
                Console.WriteLine("Numero de lados son {0}\nLado mide {1}",NumeroLados,Lado);
                Console.WriteLine("Perimetro: {0}", CalcularPerimetro());

                Console.WriteLine("Precione ENTER para salir");
                Console.ReadKey();
                Console.Clear();
            }
            public override double CalcularPerimetro()
            {
                return Lado * NumeroLados;
            }
        }
        static void Main(string[] args)
        {
            //DECLARAR VARIABLES
            char opc= 'A';
            bool Ciclo = true;//Controla el ciclo
            float Lado = 0, Base = 0, Altura = 0, NumeroLados = 0;
            //MENU
            do
            {
                Console.WriteLine("Que desea Calcular?");
                Console.WriteLine("A) ROMBO\nB) ROMBOIDE\nC)POLIGONO REGULAR \nD) SALIR?");
                opc = char.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 'A'://rombo
                        Console.WriteLine("--------------ROMBO--------------");
                        Console.Write("Medida del lado: ");
                        Lado = float.Parse(Console.ReadLine());


                        Console.WriteLine("Precione enter");
                        Console.ReadKey();
                        Console.Clear();

                        //Constructor del obejeto
                        rombo RO = new rombo(Lado);

                        //Imprimir llamado el metodo
                        RO.DesplegarPerimetro();

                        break;
                    case 'B'://romboide
                        Console.WriteLine("--------------ROMBOIDE--------------");
                        Console.Write("Medida de base: ");
                        Base = float.Parse(Console.ReadLine());

                        Console.Write("Medida de la altura: ");
                        Altura = float.Parse(Console.ReadLine());


                        Console.WriteLine("Precione enter");
                        Console.ReadKey();
                        Console.Clear();

                        //Constructor del objeto
                        romboide ROMIDO = new romboide(Base,Altura);

                        //LLamar metodo
                        ROMIDO.DesplegarPerimetro();

                        break;
                    case 'C'://poligono regular
                        Console.WriteLine("--------------POLIGONO REGULAR--------------");
                        Console.Write("Numero de lados: ");
                        NumeroLados = float.Parse(Console.ReadLine());

                        Console.Write("Medida de la lado: ");
                        Lado = float.Parse(Console.ReadLine());
                        
                        Console.WriteLine("Precione enter");
                        Console.ReadKey();
                        Console.Clear();

                        //Constructor del objeto
                        PoligonoRegular POL = new PoligonoRegular(Lado,NumeroLados);

                        //LLamar metodo
                        POL.DesplegarPerimetro();

                        break;
                    case 'D'://salida del programa
                        Console.WriteLine("Desea Salir? [Y] , [N]");
                        opc = char.Parse(Console.ReadLine());
                        if (opc == 'Y')
                        {
                            Console.WriteLine("Precione enter para SALIR");
                            Ciclo = false;
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else if (opc == 'N')
                        {

                            Console.WriteLine("Precione enter PARA REPETIR");
                            
                            Console.ReadKey();
                            Console.Clear();

                        }
                        else
                        {
                            Console.WriteLine("ERROR solo numeros y una letra Mayuscula, se reiniciara, precione ENTER");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                }
            } while (Ciclo == true);//Ciclo para el menu

            //fin del programa
        }
    }
}

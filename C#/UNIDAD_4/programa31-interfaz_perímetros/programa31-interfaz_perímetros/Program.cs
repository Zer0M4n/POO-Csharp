using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa31_interfaz_perímetros
{
    internal class Program
    {
        interface Perimetros//Interface
        {
            double CalcularPerimetro();
            void DesplegarPerimetro();
        }
        //Clase rombo
        public class rombo : Perimetros
        {
            //Campos de la clase
            public float Lado = 0;

            //Constructor de la clase
            public rombo(float Lado) 
            {
                this.Lado = Lado; 
            }
            //Metodos de la clase
            public double CalcularPerimetro() 
            {
                return Lado * 4; 
            }

            public void DesplegarPerimetro()
            {
                Console.WriteLine("--------------Rombo--------------");
                Console.WriteLine("Lado mide {0}", Lado);
                Console.WriteLine("Perimetro: {0}", CalcularPerimetro());

                Console.WriteLine("Precione ENTER para salir");
                Console.ReadKey();
                Console.Clear();
            }
            //Destructor de la clase
            ~rombo() { Console.WriteLine("Memoria de la clase rombo liberada"); }
        }
        //Clase romboide
        public class romboide : Perimetros 
        {
            //Campos de la clase
            public float Base = 0, Altura = 0;

            //Constructor de la clase
             public romboide(float Base, float Altura) 
            {
                this.Base = Base;
                this.Altura = Altura;
            }
            //Metodos de la clase
            public double CalcularPerimetro()
            {
                return (Base*2)+(Altura*2); 
            }
            public void DesplegarPerimetro()
            {
                Console.WriteLine("--------------Romboide--------------");
                Console.WriteLine("Base mide {0}\nAltura mide {1}", Base,Altura);
                Console.WriteLine("Perimetro: {0}", CalcularPerimetro());

                Console.WriteLine("Precione ENTER para salir");
                Console.ReadKey();
                Console.Clear();
            }
            //Destructor de la clase
            ~romboide() { Console.WriteLine(); }

        }
        //Clase poligono regular
        public class PoligonoRegular : Perimetros 
        {
            //Campos de la clase
            public float Lado = 0, NumeroLados = 0;

            //Constructor de la clase
            public PoligonoRegular(float Lado , float NumeroLados)
            {
                this.Lado = Lado;
                this.NumeroLados = NumeroLados;
            }
            //Metodos de la clase
            public double CalcularPerimetro()
            {
                return Lado * NumeroLados;
            }

            public void DesplegarPerimetro()
            {
                Console.WriteLine("--------------Poligono Regular--------------");
                Console.WriteLine("Lado mide {0}\nNumeros de lados : {1}", Lado,NumeroLados);
                Console.WriteLine("Perimetro: {0}", CalcularPerimetro());

                Console.WriteLine("Precione ENTER para salir");
                Console.ReadKey();
                Console.Clear();
            }

        }
        static void Main(string[] args)
        {
            char opc = 'A';
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
                        romboide ROMIDO = new romboide(Base, Altura);

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
                        PoligonoRegular POL = new PoligonoRegular(Lado, NumeroLados);

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

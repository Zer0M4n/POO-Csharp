using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria_Perimetros_prac32;//Libreira de Perimetros creada por mi
namespace programa32_uso_librería_perímetros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DECLARAR VARIABLES
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

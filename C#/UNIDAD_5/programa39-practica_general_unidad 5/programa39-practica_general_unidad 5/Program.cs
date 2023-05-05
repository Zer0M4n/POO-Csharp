using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa39_practica_general_unidad_5
{
    internal class Program
    {
        class Fuera_Rango : ApplicationException
        {
            public Fuera_Rango() : base("Elnumero alimentado esta fuera del parametro establecido")
            {

            }
        }
        class Parametro_iNVALIDO :ApplicationException
        {
            public Parametro_iNVALIDO() : base("Numero invalido para esta operacion")
            {

            }
        }
        class PARAMETROnulo : ApplicationException
        {
            public PARAMETROnulo() : base("Elvalor debe ser diferente de 0")
            {

            }
        }
        static void Main(string[] args)
        {
            //Declarmos variables
            int Base = 0,opc = 0;
            double coseno = 0, tangente = 0;
            bool continuar = true;
            do
            {
                try
                {
                        Console.WriteLine("Que desea escoger?");
                        Console.WriteLine("1.- Calcular Coseno y Tangente\n2.-salir de programa");
                        opc = int.Parse(Console.ReadLine());
                        switch (opc)
                        {
                            case 1://Opcion Calcular coseno y tangenta
                                Console.Write("Numero Base : ");
                                Base = int.Parse(Console.ReadLine());

                                if (Base > 500000)
                                {
                                    throw new Fuera_Rango();
                                }
                                else if (Base < 0)
                                {
                                    throw new Parametro_iNVALIDO();
                                }
                                else if (Base == 0)
                                {
                                    throw new PARAMETROnulo();
                                }
                                else
                                {
                                    coseno = Math.Cos(Base);
                                    tangente = Math.Tan(Base);

                                    Console.WriteLine("VALOR DE COSENO: {0}\nVALOR DE TANGENTE: {1}", coseno, tangente);
                                }
                                Console.WriteLine("Precione enter para continuar");
                                Console.ReadKey();
                                Console.Clear();


                                break;
                            case 2://Salida
                                continuar = false;
                                Console.WriteLine("Precione enter para salir");
                                Console.ReadKey();
                                break;
                            default:
                                Console.WriteLine("Opcion no valida");
                                break;
                        }
                   
                }
                catch (FormatException a)
                {
                    Console.WriteLine("\n" + a.Message);
                    Console.WriteLine("Ruta del error: {0}", a.StackTrace);
                }
                catch (PARAMETROnulo n)
                {

                    Console.WriteLine("\n" + n.Message);
                    Console.WriteLine("Ruta del error: {0}", n.StackTrace);
                }
                catch (Fuera_Rango t)
                {

                    Console.WriteLine("\n" + t.Message);
                    Console.WriteLine("Ruta del error: {0}", t.StackTrace);
                }
                catch (Parametro_iNVALIDO Z)
                {

                    Console.WriteLine("\n" + Z.Message);
                    Console.WriteLine("Ruta del error: {0}", Z.StackTrace);
                }
                finally
                {
                    Console.WriteLine("FIN DEL PROGRAMA :)");
                    Console.WriteLine("Precione enter ");
                    Console.ReadKey();
                }

            } while (continuar == true);
            
            
        }
    }
}

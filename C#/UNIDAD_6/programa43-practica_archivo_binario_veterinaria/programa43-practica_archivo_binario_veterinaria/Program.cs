using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa43_practica_archivo_binario_veterinaria
{
    internal class Program
    {
        public class VETERINARIO
        {
            BinaryWriter bw = null;//Flujo de salida -escritura
            BinaryReader br = null;//Flujo de entrada - lectura de datos

            //Campos de la clase
            string NombreMacota = "", Raza = "", Color = "", NomArch = "";
            short edad = 0, DiasHospitalizado = 0;
            float CostoXdia;

            public  void CrearArchivo(string Archivo)
            {
                NomArch = Archivo;
                char resp; //Variable local
                try
                {
                    //creacion dl flujo para escribir datos del archivo
                    bw = new BinaryWriter(new FileStream(Archivo,FileMode.Create,FileAccess.Write));


                    do
                    {
                        Console.Clear();
                        
                        Console.Write("Nombre de la mascota:  ");
                        NombreMacota = Console.ReadLine();

                        Console.Write("Raza de la mascota: ");
                        Raza = Console.ReadLine();
                        
                        Console.Write("Color de la mascota:  ");
                        Color = Console.ReadLine();

                        Console.Write("Edad : ");
                        edad = short.Parse(Console.ReadLine());

                        Console.Write("Costo por dia: ");
                        CostoXdia = float.Parse(Console.ReadLine());
                        
                        Console.Write("Dias Hospitalizado: ");
                        DiasHospitalizado = short.Parse(Console.ReadLine());

                        bw.Write(NombreMacota);
                        bw.Write(Raza);
                        bw.Write(Color);
                        bw.Write(edad);
                        bw.Write(CostoXdia);
                        bw.Write(DiasHospitalizado);

                        Console.Write("\n\nDeseas Almacenar otro registro (s/n)?  ");
                        resp = char.Parse(Console.ReadLine());


                    } while ((resp == 's' )||(resp =='S') );
                }
                catch (IOException e) 
                {
                    Console.WriteLine("ERROR : {0}",e.Message);
                    Console.WriteLine("Ruta del error: {0}",e.StackTrace);

                }
                finally
                {
                    if(bw != null)bw.Close();
                    Console.Write("\nPrecione enter para terminar escritura yregresar el menu");
                }
            }//Fin de la funcion

            public void MostrarArchivo(string Archivo)
            {
                NomArch = Archivo;

                try
                {
                    if(File.Exists(Archivo)) 
                    {
                        br = new BinaryReader(new FileStream(Archivo,FileMode.Open,FileAccess.Read));

                        Console.Clear();

                        do
                        {
                            NombreMacota = br.ReadString();
                            Raza = br.ReadString();
                            Color = br.ReadString();
                            edad = br.ReadInt16();
                            CostoXdia = br.ReadSingle();
                            DiasHospitalizado = br.ReadInt16();

                            //Mostrar datos
                            Console.WriteLine("Nombre de la mascota: {0}", NombreMacota);
                            Console.WriteLine("Raza: {0}", Raza);
                            Console.WriteLine("Color: {0}", Color);
                            Console.WriteLine("Edad: {0}", edad);
                            Console.WriteLine("Costo por dia: {0}", CostoXdia);
                            Console.WriteLine("Dias Hospitalizado: {0}", DiasHospitalizado);
                            Console.WriteLine("Costo total : {0}", CostoXdia * DiasHospitalizado);
                            Console.Write('\n');

                        } while (true);
                    }
                    else
                    {
                        Console.Clear ();
                        Console.WriteLine("\n\nEl archivo " + Archivo + "No Existe en el disco");
                        Console.Write("\nPrecione enter para un continuar");
                        Console.ReadKey();


                    }
                }
                catch (EndOfStreamException ) 
                { 
                    Console.WriteLine("\n\nFin del listado de empleado");
                    Console.Write("\n PRECIONE ENTER");
                    Console.ReadKey();
                }
                finally
                {
                    if(br != null) br.Close ();
                    Console.Write("\nPrecione enter para terminar la lectura");
                    Console.ReadKey();
                }
            }
            ~VETERINARIO() { Console.WriteLine("Memoria liberad");
            }
        }
        static void Main(string[] args)
        {
            string arch;
            char OPC = 'T';
            bool CICLO = true;
            do
            {
                switch(OPC) 
                {
                    case 'a':
                        break;
                    case 'b':
                        break;
                    case 'c':
                        break;
                    default:
                        Console.WriteLine();
                        break;
                }
            } while (CICLO == true);
        }
    }
}

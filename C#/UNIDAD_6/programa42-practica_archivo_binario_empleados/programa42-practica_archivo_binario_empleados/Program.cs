using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace programa42_practica_archivo_binario_empleados
{
    internal class Program
    {
        public class Archivo_Binario_Empleados
        {
            //declaracion de flujos
            BinaryWriter bw = null;//Flujo de salida - escritura de datos
            BinaryReader br = null;//Flujo de entrada - lectura de datos

            //Campos de la clase

            string Nombre, Direccion, NomArch;
            long Telefono;
            int NoEmpleado;
            short DiasTrabajdos;
            float SalrioDiario;

            public void Crear_Archivo(string Archivo)
            {
                NomArch = Archivo;
                char resp; //variable local metodo

                try
                {
                    //CREACION DEL FLUJO PARA ESCRIBIR DATOS DEL ARCHIVO
                    bw = new BinaryWriter(new FileStream(Archivo,FileMode.Create, FileAccess.Write));

                    //Captura de datos
                    do
                    {
                        Console.Clear();
                        Console.Write("Numero de emplado:  ");
                        NoEmpleado = int.Parse(Console.ReadLine());
                        Console.Write("Nombre del empledo:  ");
                        Nombre = Console.ReadLine();
                        Console.Write("Direccion del empleo: ");
                        Direccion = Console.ReadLine();
                        Console.Write("Telefono del empleado:  ");
                        Telefono = long.Parse(Console.ReadLine());
                        Console.Write("Dias trabajados del empledo:  ");
                        DiasTrabajdos = short.Parse(Console.ReadLine());
                        Console.Write("Salario diario del empleado:  ");
                        SalrioDiario = float.Parse(Console.ReadLine());

                        //Escribir los datos al archivo del disco
                        bw.Write(NoEmpleado);
                        bw.Write(Nombre);
                        bw.Write(Direccion);
                        bw.Write(Telefono);
                        bw.Write(DiasTrabajdos);
                        bw.Write(SalrioDiario);

                        Console.Write("\n\nDeseas almacenar otro registro(s/n)?  ");
                        resp = char.Parse(Console.ReadLine());
                    } while ((resp == 's') || (resp == 'S'));
                }
                catch(IOException ex)
                {
                    Console.WriteLine("ERROR: {0}",ex.Message);
                    Console.WriteLine("RUTA DEL ERROR: {0}",ex.StackTrace);   
                }
                finally
                {
                    if (bw != null) bw.Close();
                    Console.Write("\nPrecione <Enter> para terminar la escritura de datos y representar el menu");
                    Console.ReadKey();

                }
            }//fin del metodo crear archivo

            public void Mostrar_Archivo(string Archivo)
            {
                NomArch = Archivo;
                try
                {
                    if(File.Exists(Archivo))
                    {
                        //creacion flujoo para leer datos del archivo
                        br = new BinaryReader(new FileStream(Archivo, FileMode.Open, FileAccess.Read));

                        //Despliege datos de la pantalla
                        Console.Clear();
                        do
                        {
                            //Lecturas de datos
                            NoEmpleado = br.ReadInt32();
                            Nombre = br.ReadString();
                            Direccion = br.ReadString();
                            Telefono = br.ReadInt64();
                            DiasTrabajdos = br.ReadInt16();
                            SalrioDiario = br.ReadSingle();

                            //muestra los datos en pantalla
                            Console.WriteLine("No empleado: {0}", NoEmpleado);
                            Console.WriteLine("Nombre: {0}", Nombre);
                            Console.WriteLine("Direccion: {0}", Direccion);
                            Console.WriteLine("Telefono: {0}", Telefono);
                            Console.WriteLine("Dias trabajados: {0}", DiasTrabajdos);
                            Console.WriteLine("Salrio diario: {0}", SalrioDiario);
                            Console.WriteLine("Salrio total: {0}", DiasTrabajdos * SalrioDiario);
                            Console.WriteLine("\n");
                        } while (true);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\n\n El archivo " + Archivo + "No existe en el disco");
                        Console.Write("\nPrecione <Enter>");
                        Console.ReadKey();
                    }
                }
                catch(EndOfStreamException)
                {
                    Console.WriteLine("\n\nFin del listado de empleado");
                    Console.Write("\n Precione <ENTER>");
                    Console.ReadKey();
                }
                finally
                {
                    if(br != null) br.Close();
                    Console.Write("\nPrecione <enter> para terminar la lectura de datos y regresar al menu");
                    Console.ReadKey();
                }
            }


            //Destructor de la clase
            ~Archivo_Binario_Empleados()
            {
                Console.WriteLine("Memoria liberada de la clase");
            }
        }//Fin de la clase

        static void Main(string[] args)
        {
            //Declarar variables
            string Arch = null;
            short opcion = 0;

            //creacion del objeto
            Archivo_Binario_Empleados Al = new Archivo_Binario_Empleados();

            //menu
            do
            {
                Console.Clear();
                Console.WriteLine("\n*** ARCHIVO BINARIO EMPLEADOS***");
                Console.WriteLine("1.- Creación de un Archivo.");
                Console.WriteLine("2.- Lectura de un Archivo.");
                Console.WriteLine("3.- Salida del Programa.");
                Console.Write("\nQue opción deseas: ");
                opcion = Int16.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        //bloque de escritura

                        try
                        {
                            //captura nombre archivo

                            Console.Write("\nAlimenta el Nombre del Archivo a Crear: "); 
                            Arch = Console.ReadLine();
                            //verifica si esxiste el archivo

                            char resp = 's';
                            if (File.Exists(Arch))

                            {
                                Console.Write("\nEl Archivo Existe!!, Deseas Sobreescribirlo(s / n) ? ");
                                resp = Char.Parse(Console.ReadLine());
                            }
                            if ((resp == 's') || (resp == 'S'))
                                Al.Crear_Archivo(Arch);
                        }
                        catch (IOException e)
                        {
                            Console.WriteLine("\nError : " + e.Message);

                            Console.WriteLine("\nRuta : " + e.StackTrace);
                        }
                        break;
                    case 2:
                        //bloque de lectura

                        try
                        {
                            //captura nombre archivo

                            Console.Write("\nAlimenta el Nombre del Archivo que deseas Leer: "); 
                            Arch = Console.ReadLine();
                            Al.Mostrar_Archivo(Arch);
                        }
                        catch (IOException e)
                        {
                            Console.WriteLine("\nError : " + e.Message);

                            Console.WriteLine("\nRuta : " + e.StackTrace);
                        }
                        break;
                    case 3:
                        Console.Write("\nPresione <enter> para Salir del Programa.");
                        Console.ReadKey();

                        break;
                    default:
                        Console.Write("\nEsa Opción No Existe!!, Presione < enter > para Continuar...");
                        Console.ReadKey();

                        break;

                }
            } while (opcion != 3) ;
        }
    }
}

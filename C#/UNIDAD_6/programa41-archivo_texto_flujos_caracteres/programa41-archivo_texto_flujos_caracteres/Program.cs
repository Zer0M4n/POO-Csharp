using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;//Librerias necesarias para trabajar con archivos

namespace programa41_archivo_texto_flujos_caracteres
{
    public class Texto_Caracteres
    {
        //Campos de la clase
        StreamWriter sw = null;//declaracion flujo de escritura
        StreamReader sr = null;//declaracion flujo de lectura

        String str;//Variable auxiliar

        //metodo 1
        public void CrearArchivo()
        {
            try
            {
                //Crear flujo de escritura hacia un doc.txt
                sw = new StreamWriter("doc.txt");

                Console.WriteLine("Esciba las lineas de texto para almacenar en el archivo. \n "
                    + "Finalice cada linea pulsando la tecla <Enter>. \n"
                    + "Para finalizar la escritura pulse la tecla <ENTER>. \n");

                //Leer una linea de la entrada estandar
                str = Console.ReadLine();

                //Mientras la cadena str no este vacia escribe en el archivo
                while (str.Length != 0)
                {
                    //Escribe la linea en el archivo
                    sw.WriteLine(str);
                    //Lee la linea siguiente de la entrada estandar
                    str = Console.ReadLine();
                }
            }
            catch (IOException ex) 
            {
                Console.WriteLine("ERROR: {}",ex.Message);
                Console.WriteLine("Ruta del error: {0}",ex.StackTrace);
            }
            finally
            {
                //Cierra el flujo de escritura
                if(sw != null) sw.Close();

                Console.WriteLine("Fin del metodo crear archivo");
            }
        }//Fin de metodo

        //Metodo 2
        public void LeerARCHIVO()
        {
            try 
            {
                //Crea flujo de lectura desde el archivo "doc.txt"
                sr = new StreamReader("doc.txt");

                // lee del archivo una linea de texto
                str = sr.ReadLine();

                //Mientras la cadena str no este vacia lee en el archivo

                while(str != null)
                {
                    //Muestra la linea leida y lee la linea siguiente del archivo
                    Console.WriteLine(str);
                    str = sr.ReadLine();
                }
            }
            catch (IOException ex) 
            {
                Console.WriteLine("Error: {0}",ex.Message);
                Console.WriteLine("Ruta del error: {0}",ex.StackTrace);
            }
            finally
            {
                if (sr != null) sr.Close();
                Console.WriteLine("Fin del metodo leer archivo");
            }
        }
        //Destructor de la clase
        ~Texto_Caracteres() { Console.WriteLine("Memoria liberada"); }
    }//Fin de la clase
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarar variables
            string TEXTO = "";
            char OPC = 'A';

            //Vectores
            Texto_Caracteres Doc = new Texto_Caracteres();
            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("---------------------MENU---------------------");
                    Console.WriteLine("a)Escribir un archivo\nb)leer un archivo\nc)salir archivo");
                    Console.Write("Que deseas hacer?  ");
                    OPC = char.Parse(Console.ReadLine());

                    Console.Clear();
                    switch(OPC)
                    {
                        case 'a':
                            Console.Write("Nombre del archivo:  ");
                            TEXTO = Console.ReadLine();

                            Doc.CrearArchivo();
                            Console.ReadKey();

                            break;
                        case 'b':
                            Console.Write("Nombre del archivo:  ");
                            TEXTO = Console.ReadLine();
                            Doc.LeerARCHIVO();
                            Console.ReadKey();

                            break;
                        case 'c':
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Opcion no valida");
                            break;
                    }
                }
                catch(FormatException ex)
                {
                    Console.WriteLine("ERROR: {0}",ex.Message);
                    Console.WriteLine("RUTA DEL ERROR: {0}",ex.StackTrace);
                }
                finally
                {
                    Console.WriteLine("Programa creado por cesar gonzalez");
                }
            } while (OPC != 0);
        }
    }
}

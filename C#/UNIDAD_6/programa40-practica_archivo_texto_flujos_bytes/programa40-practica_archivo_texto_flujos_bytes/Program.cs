using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace programa40_practica_archivo_texto_flujos_bytes
{
    internal class Program
    {
        public class Texto
        {
            FileStream fs = null;//Declaracion de flujo de salida - escritura
            FileStream entrada = null;//Desclaracion flujo de entrada

            byte[] bBuffer = new byte[81];
            char[] cBuffer = new char[81];

            int nbytes = 0, car;

            public void Crear_Archivo()
            {
                try
                {
                    //Crear un flujo hacia a un archivo txt
                    fs = new FileStream("TEXTO.txt", FileMode.Create, FileAccess.Write);
                    Console.WriteLine("Escriba el texto que desee almacenar en el archivo, al finalizar precione enter");
                    while((car = Console.Read()) != '\n'&&(nbytes < bBuffer.Length))
                    {
                        bBuffer[nbytes] = (byte)car;
                        nbytes++;
                    }
                    //Escribe lalinea de texto en el archivo
                    fs.Write(bBuffer, 0, nbytes);
            }
                catch (IOException es)
                {
                    Console.WriteLine("ERROR: {0}", es.Message);
                    Console.WriteLine("RUTA DEL ERROR: {0}", es.StackTrace);
                }
                finally
                {
                    if (fs != null)
                    {
                        fs.Close();
                    }
                    Console.WriteLine("Fin de la ejecucuin del bloque finally");
                }
            }//Fin de l metodo Crear_Archivo

            public void LeerArchivo()
            {
                try
                {
                    entrada = new FileStream("TEXTO.txt", FileMode.Open, FileAccess.Read);

                    nbytes =  entrada.Read(bBuffer, 0, 81);

                    Array.Copy(bBuffer, cBuffer, bBuffer.Length);
                    String str = new String(cBuffer, 0, nbytes);

                    Console.WriteLine("\nContenido del archivo de disco :");
                    Console.WriteLine(str);
                }
                catch(IOException le) 
                {
                    Console.WriteLine("ERROR: {0}", le.Message);
                    Console.WriteLine("RUTA DEL ERROR: {0}", le.StackTrace);
                }
                finally
                {
                    if(entrada != null) entrada.Close();
                    {

                    }
                }

            }//Fin del metodo leer archivo
            ~Texto() { Console.WriteLine("meria liberada de la clase"); }
        }

        static void Main(string[] args)
        {
            //DECLARAR VARIABLES
            char OPC = 'A';
            string TEXTO = "";
            Texto ArchivoTXT = new Texto();
            do
            {
                try
                {
                    Console.WriteLine("MENU ARCHIVO TEXTO BYTES");
                    Console.WriteLine("a)Escribir un archivo\nb)leer archivo\nc)Salir del programa");
                    Console.Write("QUE DESEA HACER?  ");
                    OPC = char.Parse(Console.ReadLine());
                    switch (OPC)
                    {
                        case 'a':
                            Console.WriteLine("NOMBRE DEL ARCHIVO:  ");
                            TEXTO = Console.ReadLine();

                         
                                ArchivoTXT.Crear_Archivo();
                            Console.Clear();

                            
                                break;
                        
                        case 'b':
                            Console.Write("NOMBRE DEL ARCHIVO: ");
                            TEXTO = Console.ReadLine();
                            ArchivoTXT.LeerArchivo();
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
                catch(FormatException ES) 
                {
                    Console.WriteLine("ERROR: {0}",ES.Message);
                    Console.WriteLine("ERROR: {0}", ES.StackTrace);
                }
                finally
                {
                    Console.WriteLine("blOQUE FINALLY");
                }
                
            } while (OPC != 0);
        }
    }
}

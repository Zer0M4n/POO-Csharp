using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace programa15_clase_alumno
{
    internal class Program
    {
        class ALUMNO
        {
            //CAMPOS DE LA CLASE
            string NAME  = "", CARRERA = "";
            short numeroControl = 0,SEMESTRE = 0;
            float Promedio = 0f;
            

            //CONSTRUCTOR DE LA CLASE
            public ALUMNO(string NAME , string CARRERA ,short numeroControl,short SEMESTRE ,float Promedio)
            {
                this.NAME = NAME;
                this.CARRERA = CARRERA;
                this.numeroControl = numeroControl;
                this.SEMESTRE = SEMESTRE;
                this.Promedio = Promedio;


            }


            //METODO DE LAS CLASES
            public void VISUALIZAR()//Metodo para hacer el procedimiento
            {
                Console.Write($"El estudiante {NAME} , con el numero de control {numeroControl} de la carrera {CARRERA} y del semestre {SEMESTRE} , Con un promedio {Promedio}" );
            }
          
            //DESTRUCTOR DE LA CLASE
            ~ALUMNO() 
            {
                Console.WriteLine("\nMEMORIA LIBERADA DE LA CLASE PERSONA\n"); 
            }//LIBERA LA MEMORIA DE LA CLASE ALUMNO
        }
      

        static void Main(string[] args)
        {
            //DECLARAR VARIABLES
            float  Promedio = 98f;
            string NAME = "Cesar Gonzalez Salazar", CARRERA = "SISTEMAS COMPUTACIONALES";
            short numeroControl = 12345 ,SEMESTRE = 4 ;
            
            //CREACION DEL OBJETO

            ALUMNO estudiante = new ALUMNO(NAME, CARRERA, numeroControl, SEMESTRE, Promedio);

            estudiante.VISUALIZAR();//LLamamos el procedimiento para que imprima los datos

            Console.WriteLine(" \nPrecione enter para salir del  programa");
            Console.ReadKey();//Detiene el programa hasta que se precione enter

            
        }
    }
}

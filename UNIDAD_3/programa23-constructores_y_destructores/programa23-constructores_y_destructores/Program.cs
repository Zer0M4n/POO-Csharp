using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace programa23_constructores_y_destructores
{
    internal class Program
    {
        public class ESCUELA //CLASE BAS
        {
            //CAMPOS DE CLASE

            public string NombreEscuela = "";
            public long Telefono = 0;
            public string Direccion = "";

            //Constructor de la clase
            public ESCUELA (string NombreEscuela,long Telefono, string Direccion)
            {
                this.NombreEscuela = NombreEscuela;
               this .Telefono = Telefono;
                this .Direccion = Direccion;
            }
            //METODOS DE LA CLASE
            public void DesplegarEscuela()
            {
                Console.Write("Nombre de la escuela: {0}\nNumero de telefono: {1}\nDireccion: {2}\n",NombreEscuela,Telefono,Direccion) ;
            }
            //DESTRUCTOR DE LA CLASE

            ~ESCUELA() { Console.Write("\nMemoria liberada de la clase ESCUELA "+ NombreEscuela); }
        }
        public class ALUMNO:ESCUELA //CLASE DERIVADA 1
        {
            //CAMPOS DE CLASE
            string NombreAlumno = "";
            int NumeroControl = 0;
            string Carrera = "";
            byte Semestre = 0;
            //Constructor de la clase
            public ALUMNO(string NombreAlumno,int NumeroControl ,string Carrera ,byte Semestre, string NombreEscuela, long Telefono, string Direccion) :base(NombreEscuela,Telefono,Direccion)
            {
                this.NumeroControl = NumeroControl; 
                this.Carrera = Carrera;
                this.Semestre = Semestre;
                this.NombreAlumno = NombreAlumno;
            }
         
            //METODOS DE LACLASE
            public void DesplegarAlumno()
            {
                Console.Write("Nombre del alumno: {0}\nNumero de Control: {1}\nSemestre: {2}\nCarrera: {3}",NombreAlumno,NumeroControl,Semestre,Carrera);
            }
            //DESTRUCTOR DE LA CLASE
            ~ALUMNO() { Console.Write("\n\nMEMORIA LIBERADA DE LA CLASE ALUMNO {0}\n",NombreAlumno); }
        }
        public class Profesor : ESCUELA
        {
            //campos de la clase

            public string NombreProfesor = "",Departamento = "", Profecion = "";
            public int NumeroAfilicion = 0;

            //Constructor de la clase

            public Profesor(string NombreProfesor, string Departamento, int NumeroAfilicion,string Profecion , string NombreEscuela, long Telefono, string Direccion) : base(NombreEscuela,Telefono,Direccion)
            {
                this.NombreProfesor = NombreProfesor;
                this.Departamento= Departamento;
                this.NumeroAfilicion= NumeroAfilicion;
                this.Profecion = Profecion;
            }

            //METODOS DE LACLASE
            public void DesplegarProfesor()
            {
                Console.Write("Nombre del profesor: {0}\nDepartamento: {1}\nNumero de afiliacion: {2}\nProfecion: {3}",NombreProfesor,Departamento,NumeroAfilicion,Profecion);
            }
            //DESTRUCTOR DE LA CLASE
            ~Profesor() { Console.Write("\nMEMORIA LIBERAD DE LA CLASE Profesor {0}\n", NombreProfesor); }
        }

        static void Main(string[] args)
        {

             //INICIALIZAZ VARIBLES
            string NombreProfesor = "", Departamento = "", Profecion = "",Carrera = "",NombreEscuela = "", Direccion = "", NombreAlumno = "";
            int NumeroAfilicion = 0, NumeroControl = 0;
            byte Semestre = 0;
            long Telefono = 0;

            //CAPTURAR DATOS ESCUELA
            Console.Write("-------------DATOS DE LA ESCUELA-------------\n");
            Console.Write("NOMBRE DE LA ESCUELA:  ");
            NombreEscuela = Console.ReadLine();
            Console.Write("DIRECCION: ");
            Direccion = Console.ReadLine();
            Console.Write("TELEFONO: ");
            Telefono = long.Parse(Console.ReadLine());

            //CERECION DEL OBJETO ESCUELA
            ESCUELA Instalacion = new ESCUELA(NombreEscuela, Telefono, Direccion);

            Instalacion.DesplegarEscuela();

            Console.Write("Precione ENTER para continuar");
            Console.ReadKey();
            Console.Clear();//LIMPIAR PANTALLA


            //CPATURAR DATOS DEL ESTUDIANTE
            Console.Write("-------------DATOS DEL ESTUDIANTE-------------\n");
            Console.Write("NOMBRE DEL ALUMNO: ");
            NombreAlumno = Console.ReadLine();
            Console.Write("NUMERO DE CONTROL: ");
            NumeroControl = int.Parse(Console.ReadLine());
           
            Console.Write("SEMESTRE: ");
            Semestre = byte.Parse(Console.ReadLine());
            
            Console.Write("CARRERA: ");
            Carrera = Console.ReadLine();

            // CREACION DEL OBJETO
            ALUMNO estudiante = new ALUMNO(NombreAlumno, NumeroControl,Carrera,Semestre,Instalacion.NombreEscuela,Instalacion.Telefono,Instalacion.Direccion);

            //IMPRIMIR METODOS

            estudiante.DesplegarEscuela();
            estudiante.DesplegarAlumno();

            Console.Write("Precione ENTER para continuar");
            Console.ReadKey();
            Console.Clear();//LIMPIAR PANTALLA

            //CAPTURAR DATOS DEL PROFESOR
            Console.Write("-------------DATOS DEL PROFESOR-------------\n");
            Console.Write("NOMBRE DEL PROFESOR: ");
            NombreProfesor = Console.ReadLine();
            Console.Write("DEPARTAMENTO: ");
            Departamento = Console.ReadLine();
            Console.Write("NUMERO DE AFILIACION: ");
            NumeroAfilicion = int.Parse(Console.ReadLine());
            Console.Write("PROFECION: ");
            Profecion = Console.ReadLine();

            //Creacion del objetos

            Profesor Docento = new Profesor(NombreProfesor,Departamento,NumeroAfilicion,Profecion,Instalacion.NombreEscuela,Instalacion.Telefono,Instalacion.Direccion);

            //IMPRIMIR METODOS
            Docento.DesplegarEscuela();
            Docento.DesplegarProfesor();

            Console.Write("\nPrecione ENTER para salir\n");
            Console.ReadKey();

        }
    }
}

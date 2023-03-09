using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa20_practica_unidad_2
{
    internal class Program
    {
        class Escolares_ITT
        {
            //Campos de la clase
            string NombreAlumno = "" ,Carrera = "",Turno = "";
            sbyte Semestre = 0;
            long NumeroControl = 0;
         

            //Constructor de la clase

            public Escolares_ITT(string NombreAlumno,string Carrera,string Turno,sbyte Semestre,long NumeroControl)
            {
                this.NombreAlumno = NombreAlumno;
                this .Carrera = Carrera;
                this .Turno = Turno;
                this.Semestre = Semestre;
                this.NumeroControl = NumeroControl;
               

            }
          

            //Metodos de la clase

            public float CalculaIncripcion(float CuotaIncripcion)
            {
                return (CuotaIncripcion) + (CuotaIncripcion * 0.8f );
            }
            public float CalculaIncripcion(float CuotaIncripcion, float CuotaSociedarAlumnos)
            {
                return (CuotaIncripcion+CuotaSociedarAlumnos )+(0.8f*(CuotaIncripcion+CuotaSociedarAlumnos));
            }
            public float CalculaIncripcion(float CuotaIncripcion, float CuotaSociedarAlumnos, float AdeudosBiblioteca)
            {
                return (CuotaIncripcion+CuotaSociedarAlumnos+AdeudosBiblioteca)+(.8f*(CuotaIncripcion+CuotaSociedarAlumnos*AdeudosBiblioteca));
            }
            //sobrecarga
           

            //Cuota de la escuela

            public void Dessplegar(float CuotaIncripcion , float CuotaSociedarAlumnos, float AdeudosBiblioteca)//Funcio procedimiento
            {
                Console.WriteLine("Nombre del alumno : {0}\nNumero de control {1}\nSemestre : {2},\nTurno {3}",NombreAlumno,NumeroControl,Semestre,Turno);
                Console.WriteLine("Cuota de incripcion caso 1 {0:C}",CalculaIncripcion(CuotaIncripcion));
                Console.WriteLine("Cuota de incripcion caso 2  {0:C}", CalculaIncripcion(CuotaIncripcion,CuotaSociedarAlumnos));
                Console.WriteLine("Cuota de incripcion caso 3  {0:C}", CalculaIncripcion(CuotaIncripcion,CuotaSociedarAlumnos,AdeudosBiblioteca));
                
            }


            //  Destructor de la clase
            ~Escolares_ITT() { Console.Write("\nMemoria liberada de la clase Escolares ITT"); }


        }
        static void Main(string[] args)
        {
            //DECLARA VARIABLES
            string NombreAlumno = "", Carrera = "", Turno = "";
            sbyte Semestre = 0;
            long NumeroControl = 0;
            float AdeudosBiblioteca = 0f, CuotaIncripcion = 0f,CuotaSociedarAlumnos = 0;

            //CAPTURAR DATOS
            Console.Write("Nombre: ");
            NombreAlumno = Console.ReadLine();

            Console.Write("Semestre : ");
            Semestre = sbyte.Parse(Console.ReadLine());

            Console.Write("Numero de Control: ");
            NumeroControl = long.Parse(Console.ReadLine());

            Console.Write("Carrera: ");
            Carrera = Console.ReadLine();

            Console.Write("Turno : ");
            Turno = Console.ReadLine();

            Console.Clear();
            
            Console.Write("Adeudo de biblioteca : ");
            AdeudosBiblioteca = float.Parse(Console.ReadLine());
            Console.Write("Cuota de inscripcion : ");
            CuotaIncripcion = float.Parse(Console.ReadLine());
            Console.Write("Cuota de sociedad de alumnos: ");
            CuotaSociedarAlumnos = float.Parse(Console.ReadLine());

            Console.Clear();
            //DEclarar objetos

            Escolares_ITT Alumno = new Escolares_ITT(NombreAlumno,Carrera,Turno,Semestre,NumeroControl);

            //Desplegar datos

            Alumno.Dessplegar(CuotaIncripcion,CuotaSociedarAlumnos,AdeudosBiblioteca);

            Console.WriteLine("Precione Enter para salir");
            Console.ReadKey();
        }
    }
}

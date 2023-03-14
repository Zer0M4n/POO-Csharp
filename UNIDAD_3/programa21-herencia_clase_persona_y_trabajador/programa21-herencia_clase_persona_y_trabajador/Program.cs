using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa21_herencia_clase_persona_y_trabajador
{
    internal class Program
    {
        class Persona
        {
            //Campos de la clase

            public string Nombre = "";
            public int Edad = 0;
            public string NIP = "";

            //Constructor de la clase
            public Persona(string Nombre, int Edad, string NIP) 
            {
                this.Nombre = Nombre;
                this.Edad = Edad;
                this.NIP = NIP;
            }

            //Metodos de la clase
            
            public void Cumpleanos()
            {
                Edad++;
                
            }

            public void DesplegarPersona()
            {
                Console.WriteLine("Datos de la persona");
                Console.WriteLine("Nombre:{0}\nEdad:{1}\nNIP:{2}", Nombre, Edad, NIP);
            }

            //Destructor de la clase
            ~Persona() { Console.WriteLine("Se ha liberado la memria de la clase persona"); }
        }
        class Trabajador:Persona
        {
            //Campos de la clase

            public float sueldo = 0f;

            //Constructor de Trabajador
            public Trabajador(string Nombre, int Edad, string NIP, float sueldo)
                : base(Nombre, Edad, NIP)
            {
                this.sueldo = sueldo;
            }
            //Metodoos de la clase
            public void DesplegarTrabajador()
            {
                Console.WriteLine("Datos de la Trabajador");
                Cumpleanos();
                
                Console.Write("Nombre:{0}\nEdad:{1}\nNIP:{2}\nSueldo:{3:c}",Nombre,Edad,NIP,sueldo);
            }

            //Destructor de la clase
            ~Trabajador() { Console.WriteLine("Se ha liberado la memria de la clase Trabajador"); }
        }
        static void Main(string[] args)
        {
            //Declarar variables
            float sueldo = 0f;
            string NIP = "", Nombre = "";
            int Edad = 0;

            //CAPTURAR DATOS

            Console.Write("Cual es su nombre?  ");
            Nombre = Console.ReadLine();
            Console.Write("Cual es su edad?  ");
            Edad = int.Parse(Console.ReadLine());
            Console.Write("Cual es su NIP ?" );
            NIP = Console.ReadLine();
            Console.Write("Sueldo : ");
            sueldo = float.Parse(Console.ReadLine());

            //CREAR OBJETO DE CLASE PERSONA
            Persona Persona = new Persona(Nombre,Edad,NIP);

            //CREar un obejto clase Trabajador
            Trabajador Obrero = new Trabajador(Persona.Nombre, Persona.Edad, Persona.NIP,sueldo);

            //Limpiar pantalla

            Console.Clear();

            //Mostrar metodos

            Persona.DesplegarPersona();
            Obrero.DesplegarTrabajador();

            Console.ReadLine();
        }
    }
}

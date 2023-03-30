using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace programa_26_polimorfismo_por_herencia
{
    internal class Program
    {
        //Clase base
        class Animal
        {
           //Metodos de la clase
           public void Desolazarce() { }

            //Destructor de la clase
            ~Animal() { Console.WriteLine("Memoria liberada de la clase Animal"); }
        }  
        class Mamifero : Animal
        {
            //Campod de la clase
            public string nombre;

            //Constructor de la clase
            public Mamifero(string nombre) { this.nombre = nombre; }

            //Reutilizar metodo de la clase base
            public new void Desolazarce() { Console.WriteLine("\nHola mi nombre es {0} y me desplazo caminando",nombre); }

            //Destructor de la clase
            ~Mamifero() { Console.WriteLine("Memoria liberada de la clase Mamifero " + this.nombre); }
        }   
        class ave : Animal
        {
            //Campod de la clase
            public string nombre;
            //Constructor de la clase
            public ave(string nombre) { this.nombre = nombre; }
            //Reutilizar metodo de la clase base
            public new void Desolazarce() { Console.WriteLine("\nHola mi nombre es {0} y me desplazo volando", nombre); }
            //Destructor de la clase
            ~ave() { Console.WriteLine("Memoria liberada de la clase ave " + this.nombre); }
        }
        
        class pez : Animal
        {
            //Campod de la clase
            public string nombre;
            //Constructor de la clase
            public pez(string nombre) { this.nombre = nombre; }
            //Reutilizar metodo de la clase base
            public new void Desolazarce() { Console.WriteLine("\nHola mi nombre es {0} y me desplazo nadando", nombre); }
            //Destructor de la clase
            ~pez() { Console.WriteLine("Memoria liberada de la clase pez " + this.nombre); }

        }
        class Reptil: Animal
        {
            //Campod de la clase
            public string nombre;
            //Constructor de la clase
            public Reptil(string nombre) { this.nombre = nombre; }
            //Reutilizar metodo de la clase base
            public new void Desolazarce() { Console.WriteLine("\nHola mi nombre es {0} y me desplazo Raptiando", nombre); }
            //Destructor de la clase
            ~Reptil() { Console.WriteLine("Memoria liberada de la clase Reptil " + this.nombre); }
        }
        
        static void Main(string[] args)
        {
            //Declarar varibles

            string nombre = "";

            //Capturar variables
            Console.Write("Ingrese el nombre del mamifero: ");
            nombre = Console.ReadLine();

            //Crear objeto de la clase mamifero
            Mamifero mamifero = new Mamifero(nombre);

            //LLAMAR METODO
            mamifero.Desolazarce();

            //Capturar variables del ave
            Console.Write("Ingrese el nombre del ave: ");
            nombre = Console.ReadLine();

            //Crear objeto de la clase ave
            ave ave = new ave(nombre);

            //LLAMAR METODO
            ave.Desolazarce();

            //Capturar variables de la clase  pez
            Console.Write("Ingrese el nombre del pez: ");
            nombre = Console.ReadLine();

            //Crear objeto de la clase pez
            pez pez = new pez(nombre);

            //LLAMAR METODO
            pez.Desolazarce();

            //Capturar variables de la clase  Reptil
            Console.Write("Ingrese el nombre del Reptil: ");
            nombre = Console.ReadLine();


            //Crear objeto de la clase Reptil
            Reptil reptil = new Reptil(nombre);

            //LLAMAR METODO
            reptil.Desolazarce();

            Console.WriteLine("\nPrecione ENTER para salir del programa");
            Console.ReadKey();
        }
    }
}

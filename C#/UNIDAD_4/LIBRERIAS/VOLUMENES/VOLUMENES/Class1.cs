using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VOLUMENES
{
    public class Esfera
    {
        //campo
        float radio;
        //constructor
        public Esfera(float radio)
        { this.radio = radio; }
        //métodos
        public double calcularVolumen()
        {
            return (4 / 3f) * Math.PI * Math.Pow(radio, 3);
        }
        public void desplegarVolumen(double volumen)
        {
            Console.WriteLine("-------------------Esfera-------------------");
            Console.WriteLine("El Radio de la Esfera es: {0}", this.radio);
            Console.WriteLine("El Volumen de la Esfera es: {0}", volumen);
            Console.WriteLine("PRECIONE ENTER PARA CONTINUAR");
            Console.ReadKey();
            Console.Clear();
        }
        //destructor
        ~Esfera()
        { Console.WriteLine("Memoria Objeto Clase Esfera Liberada"); }
    }//fin clase esfera
    public class Cubo
    {
        //campo de la clase
        public float lado;

        //Constructor de la clase

        public Cubo(float lado)
        {
            this.lado = lado;
        }

        //Metodos de la clase

        public double CalcularVolumen()
        {
            return Math.Pow(lado, 3);
        }

        public void desplegarVolumen(double volumen)
        {
            Console.WriteLine("-------------------Cubo-------------------");
            Console.WriteLine("El lado de la Esfera es: {0}", this.lado);
            Console.WriteLine("El Volumen de la Esfera es: {0}", volumen);
            Console.WriteLine("PRECIONE ENTER PARA CONTINUAR");
            Console.ReadKey();
            Console.Clear();
        }

        //Destructor de la clase

        ~Cubo() { Console.WriteLine("Memoria de la clase Cubo"); }

    }//Fin de la clase Cubo
    public class Cilindro
    {
        //Campos de la clase
        public float radio, altura;

        //Constructor de la clase
        public Cilindro(float radio, float altura)
        {
            this.radio = radio;
            this.altura = altura;
        }

        //Metodos de la clase
        
        public double CalcularVolumen()
        {
            return Math.PI * Math.Pow(radio,3);
        }
        public void desplegarVolumen(double volumen)
        {
            Console.WriteLine("-------------------Cilindro-------------------");
            Console.WriteLine("El Radio de la Esfera es: {0}\nLa altura es: {1}", this.radio,this.altura);
            Console.WriteLine("El Volumen de la Esfera es: {0}", volumen);
            Console.WriteLine("PRECIONE ENTER PARA CONTINUAR");
            Console.ReadKey();
            Console.Clear();
        }

        //Destructor de la clase
        ~Cilindro() { Console.WriteLine("Se ha liberado memoria de la clase cilindro"); }
    }//Fin de la clase cilindro

    public class Cono
    {
        //Campos de la clase
        public float radio, altura;

        //Constructor de la clase
        public Cono(float radio, float altura)
        {
            this.radio = radio;
            this.altura = altura;
        }
        //Metodos de la clase
        public double CalcularVolumen() 
        {
            return (1.0 / 3.0) * Math.PI * Math.Pow(radio, 2) * altura; ;
        }
        public void desplegarVolumen(double volumen)
        {
            Console.WriteLine("-------------------Cono-------------------");
            Console.WriteLine("El Radio de la Esfera es: {0}\nLa altura es: {1}", this.radio,this.altura);
            Console.WriteLine("El Volumen de la Esfera es: {0}", volumen);

            Console.WriteLine("PRECIONE ENTER PARA CONTINUAR");
            Console.ReadKey();
            Console.Clear();
        }
        ~Cono() { Console.WriteLine("Sea liberado la clase Cono"); }

    }//Fin de la clase cilindro

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Perimetros_prac32
{
    abstract public class Perimetro//Clase abstracta del Perimetro
    {
        //Campos de la clase
        public float Lado = 0, Base = 0, Altura = 0, NumeroLados = 0;

        //Metodos de la clase
        abstract public double CalcularPerimetro();

        abstract public void DesplegarPerimetro();
        //Desrructor de la clase
        ~Perimetro() { Console.WriteLine("Memoria liberada de la clase abstracta"); }
    }

    //Clase rombo
    public class rombo : Perimetro
    {
        //Constructo de la clase
        public rombo(float Lado) { this.Lado = Lado; }
        //Metodos de la clase
        public override double CalcularPerimetro()
        {
            return 4 * Lado;
        }
        public override void DesplegarPerimetro()
        {

            Console.WriteLine("--------------Rombo--------------");
            Console.WriteLine("Lado mide {0}", Lado);
            Console.WriteLine("Perimetro: {0}", CalcularPerimetro());

            Console.WriteLine("Precione ENTER para salir");
            Console.ReadKey();
            Console.Clear();
        }
        //Destructor de la clase
        ~rombo() { Console.WriteLine("Memoria liberada de la clase rombo"); }
    }
    //Clase Romboide
    public class romboide : Perimetro
    {
        //Constructor de la clase
        public romboide(float Base, float Altura)
        {
            this.Base = Base;
            this.Altura = Altura;
        }

        //Metodos de la clase
        public override void DesplegarPerimetro()
        {

            Console.WriteLine("--------------Romboide--------------");
            Console.WriteLine("Base: {0}\nAltura: {1}", Base, Altura);
            Console.WriteLine("Perimetro: {0}", CalcularPerimetro());

            Console.WriteLine("Precione ENTER para salir");
            Console.ReadKey();
            Console.Clear();
        }
        public override double CalcularPerimetro()
        {
            return (2 * Base) + (2 * Altura);
        }
        ~romboide() { Console.WriteLine("Memria liberada de la clase romboide"); }
    }
    //Clase
    public class PoligonoRegular : Perimetro
    {
        //Constructor de la clase
        public PoligonoRegular(float Lado, float NumeroLados)
        {
            this.Lado = Lado;
            this.NumeroLados = NumeroLados;
        }
        //Metodos de la clase
        public override void DesplegarPerimetro()
        {
            Console.WriteLine("--------------Poligono Regular--------------");
            Console.WriteLine("Numero de lados son {0}\nLado mide {1}", NumeroLados, Lado);
            Console.WriteLine("Perimetro: {0}", CalcularPerimetro());

            Console.WriteLine("Precione ENTER para salir");
            Console.ReadKey();
            Console.Clear();
        }
        public override double CalcularPerimetro()
        {
            return Lado * NumeroLados;
        }
        ~PoligonoRegular() { Console.WriteLine("Memoria liberada de la clase Poligono Regular"); }
    }
}

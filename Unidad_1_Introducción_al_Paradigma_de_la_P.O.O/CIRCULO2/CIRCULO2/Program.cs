using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIRCULO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            circulo micirculo;//Objeto de tipo circulo. Actua una variablr

            micirculo = new circulo();//Iniciacion de variable objeto de tipo circulo

            micirculo.AREA(5.8);//Corpotamiento definido

            //IMPRIMIR TEXTO

            Console.WriteLine(micirculo.AREA(5.8));

            Console.ReadKey();
        }
    }

    public class circulo//ESTO ES UNA CLASE
    {
        //Crearemos objetos , para nuestra clase

        double pi = 3.1416; //propiedad de la clase

        public double AREA(double radio)//Metodo de clase
        {
            return pi * radio * radio;//usamos la funcion return 
        }
    }
}
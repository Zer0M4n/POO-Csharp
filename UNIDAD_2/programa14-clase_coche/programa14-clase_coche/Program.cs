using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa14_clase_coche
{
    internal class Program
    {
        class Coche
        {
            //campos de la clase
            string color, modelo;
            int velocidadMaxima;
            bool motorEncendido;
            //constructor de la clase
            public Coche(string sColor, string sModelo, int iVelocidadMaxima)
            {
                color = sColor;
                modelo = sModelo;
                velocidadMaxima = iVelocidadMaxima;
                motorEncendido = false;
            }
            //métodos de la clase
            public void arrancar()
            {
                if (motorEncendido == true)
                    Console.WriteLine("El motor ya estaba encendido");
else
                {
                    motorEncendido = true;
                    Console.WriteLine("El motor acaba de encender");
                }
            }
            public void visualizar()
            {
                Console.WriteLine("Este coche es un " + modelo + ", de color " + color);
                if (motorEncendido == true)
                    Console.WriteLine("El motor está encendido.");
                else Console.WriteLine("El motor está apagado.");
            }
            ~Coche()
            {
                Console.Write("MemoriaA LIBERADA ");
            }
        }

        static void Main(string[] args)
        {
            //dECLARAR VARIABLES

            string sColor, sModelo;
            int iVelocidadMaxima;

            //Capturar datos

            Console.Write("Cual es el color  ");
            sColor = Console.ReadLine();

            Console.Write("Cual es el modelo");
            sModelo = Console.ReadLine();

            Console.Write("Cual es el velocidad   ");
            iVelocidadMaxima = int.Parse(Console.ReadLine());

            Coche auto = new Coche(sColor,sModelo,iVelocidadMaxima); 

             
            //imprimir los resultados

            auto.arrancar();
            auto.visualizar();

            Console.WriteLine("precione enter para salir");
            Console.ReadKey();


        }
    }
}

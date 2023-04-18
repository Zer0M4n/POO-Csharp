using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VOLUMENES;

namespace Prac29_Volumenes_Librerias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarar variables
            float radio, Altura, lado;
            double resultado;


            //CAPTURAR LOS DATOS DE LA ESFERA

            Console.Write("Radio :  ");
            radio = float.Parse(Console.ReadLine());

            //Constructor de la clase
            Esfera esfera = new Esfera(radio);

            //Damos valor al resultado
            resultado = esfera.calcularVolumen();
            //Desplegar metodo
            esfera.desplegarVolumen(resultado);



            //CAPTURAR LOS DATOS DE LA CUBO
            Console.Write("Lado :  ");
            lado = float.Parse(Console.ReadLine());

            //Constructor del objeto
            Cubo cub = new Cubo(radio);

            //Damos valor al resultado
            resultado = cub.CalcularVolumen();

            //Desplegar metodo
            cub.desplegarVolumen(resultado);



            //CAPTURAR LOS DATOS DE LA CILINDRO
            Console.Write("Radio:  ");
            radio = float.Parse(Console.ReadLine());

            Console.Write("Altura:  ");
            Altura = float.Parse(Console.ReadLine());

            //Constructor del cilindro
            Cilindro cil = new Cilindro(radio, Altura);

            //Damos valor al resultado
            resultado = cil.CalcularVolumen();

            //Desplegar metodo
            cil.desplegarVolumen(resultado);


            //CAPTURAR LOS DATOS DE LA CONO
            Console.Write("Radio:  ");
            radio = float.Parse(Console.ReadLine());

            Console.Write("Altura:  ");
            Altura = float.Parse(Console.ReadLine());

            //Constructor de la clase Cono
            Cono con = new Cono(radio, Altura);

            //Damos valor el resultado
            resultado = con.CalcularVolumen();
            //Imprimimoe el metodo
            con.desplegarVolumen(resultado);

            Console.WriteLine("\n\nPRECIONE ENTER PARA CONTINUAR");
            Console.ReadKey();
        }
    }
}

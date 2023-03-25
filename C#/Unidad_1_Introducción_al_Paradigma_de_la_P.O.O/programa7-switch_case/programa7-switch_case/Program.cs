using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace programa7_switch_case
{
    internal class Program
    {
        static void Main(string[] args)
        {//Programa con swich case calculadora basica (suma , resta, multiplicacion y division) para dos numeros

            //declarar variables
            float numero1 = 0, numero2 = 0, resultado = 0;
            string opc = "", repetir = "";//operador para las opciones
            ;//Esta variable nos ayudara para ver si se repeite el ciclo
                         

            

            do//USAMOS UN CICLO PARA VOVEL AL INICIO SI LO NECESITAMOS
            {
                //capturamos los datos
                //MENU solo texto
                Console.WriteLine("CALCULADORA BASICA:" +
                    "\n1)SUMA \n2)RESTA \n3)MULTIPLICACION \n4)DIVISION");

                Console.Write("Por favor escriba lo que quiere operar EN MAYUSCULAS Y SIN NUMEROS: ");
                opc= Console.ReadLine();

                switch(opc)
                {
                    case "SUMA":
                        //capturamos los datos de para la suma
                        Console.Write("Numero 1: ");
                        numero1 = float.Parse(Console.ReadLine());

                        Console.Write("Numero 2: ");
                        numero2 = float.Parse(Console.ReadLine());
                         //proceso de la suma
                        resultado = numero1 + numero2;

                        //imprimimos resultado
                        Console.Write("El resultado de la suma es {0}",resultado);
                        break;
                    case "RESTA":
                        //capturamos datos
                        Console.Write("Numero 1: ");
                        numero1 = float.Parse(Console.ReadLine());

                        Console.Write("Numero 2: ");
                        numero2 = float.Parse(Console.ReadLine());

                        //procesamos 
                        resultado = numero1- numero2;

                        //imprimimos resultado
                        Console.Write("El resultado de la resta es {0}", resultado);
                        break;
                    
                    case "MULTIPLICACION":
                        //capturamos datos
                        Console.Write("Numero 1: ");
                        numero1 = float.Parse(Console.ReadLine());

                        Console.Write("Numero 2: ");
                        numero2 = float.Parse(Console.ReadLine());

                        //procesamos 
                        resultado = numero1 * numero2;

                        //imprimimos resultado
                        Console.Write("El resultado de la multiplicacion es {0}", resultado);
                        break;
                    case "DIVISION":
                        //cpturamos datos
                        Console.Write("Numero 1: ");
                        numero1 = float.Parse(Console.ReadLine());

                        Console.Write("Numero 2: ");
                        numero2 = float.Parse(Console.ReadLine());

                        //procesamos 
                        resultado = numero1 / numero2;

                        //imprimimos resultado
                        Console.Write("El resultado de la division es {0}", resultado);
                        break;
                }
                Console.Write("\nQuieres calclar otro valor? [Y/N]:  ");
                repetir = Console.ReadLine();

                Console.Clear();//BORRAMOS LA PANTALLA

            } while (repetir == "Y");
            Console.WriteLine("PRECIONE ENTER PARA SALIR");
            Console.ReadKey();
        }
    }
}

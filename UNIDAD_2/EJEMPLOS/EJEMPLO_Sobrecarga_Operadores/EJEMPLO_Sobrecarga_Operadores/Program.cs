using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//EJEMPLO DE SOBRECARGA DE OPERADORES
/*Plantear una clase VectorEnteros que permita crear un vector de 5 elementos 
  y sobrecargue el operador * de un objeto de la clase VectorEnteros con un valor 
  de tipo int (el resultado debe ser otro objeto de la clase VectorEnteros donde cada componente se obtiene de
 multiplicar su valor por el valor entero)*/
namespace EJEMPLO_Sobrecarga_Operadores
{
    internal class Program
    {
        class VectorEnteros//VECTORES ENTEROS
        {
            private int[] vec;//METODOS

            public VectorEnteros()//CONSTRUCTOR DE LA CLASE
            {
                vec = new int[5];
            }

            public void Cargar()//FUNCION PROCEDIMIENTO
            {
                for (int f = 0; f < vec.Length; f++)
                {
                    Console.Write("Ingrese componente:");
                    vec[f] = int.Parse(Console.ReadLine());
                }
            }

            public void Imprimir()
            {
                for (int f = 0; f < vec.Length; f++)
                {
                    Console.Write(vec[f] + " ");
                }
                Console.WriteLine();
            }

            public static VectorEnteros operator *(VectorEnteros v1, int valor)
            {
                VectorEnteros resu = new VectorEnteros();
                for (int f = 0; f < resu.vec.Length; f++)
                {
                    resu.vec[f] = v1.vec[f] * valor;
                }
                return resu;
            }
        }
            static void Main(string[] args)
        {
            VectorEnteros v1 = new VectorEnteros();
            Console.WriteLine("Carga del vector");
            v1.Cargar();
            VectorEnteros vr;
            Console.WriteLine("Primer Vector");
            v1.Imprimir();
            vr = v1 * 10;
            Console.WriteLine("Vector resultante");
            vr.Imprimir();
            Console.ReadKey();
        }
    }
}

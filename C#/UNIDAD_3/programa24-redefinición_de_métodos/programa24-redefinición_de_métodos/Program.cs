using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa24_redefinición_de_métodos
{
    internal class Program
    {
        class AREAS//CLASE BASE
        {
            //CAMPOS DE LA CLASE

            public float RADIO = 0f;

            //CONSTRUCTOR DE LA CLASE
            public AREAS (float RADIO)
            {
                this.RADIO = RADIO;
            }

            //METODOS
            public virtual float CALCULARAREA() { return 0; }
            public virtual void ImprimirArea() { }
            //DESTRUCTOR
            ~AREAS() { Console.Write("\nMemoria liberada de la clase AREAS\n"); }
        }

        class CIRCULO : AREAS //CLASE DERIVADA 1
        {
           
            //CONSTRUCTOR DE LA CLASE
            public CIRCULO(float RADIO) : base(RADIO) { }
            //METODOS
            public override float CALCULARAREA()
            {
                
                return (float)(Math.PI * Math.Pow(RADIO, 2)) ;
            }
            public override void ImprimirArea()
            {
                Console.Write("\nArea del circulo: {0}",CALCULARAREA());
            }
            //DESTRUCTOR
            ~CIRCULO() { Console.Write("\nMemoria liberada de la clase CIRCULO");}
        }
        class ESFERA : AREAS //CLASE DERIVADA 2
        {
            //CONSTRUCTOR DE LA CLASE
            public ESFERA(float RADIO) : base(RADIO) { }
            //METODOS
            public override float CALCULARAREA()
            {
                return (float)(4*Math.PI*Math.Pow(RADIO,2));

            }

            public override void ImprimirArea()
            {
                Console.Write("\nArea de la esfera: {0}",CALCULARAREA()) ;
            }
            //DESTRUCTOR
            ~ESFERA() { Console.Write("\nMemoria liberada de la clase ESFERA"); }
        }

        class CILINDRO : AREAS //CLASE DERIVADA 3
        {
            //Campos de la clase
            public float ALTURA = 0f;
            //CONSTRUCTOR DE LA CLASE
            public CILINDRO(float ALTURA ,float RADIO) : base(RADIO) 
            {
                this.ALTURA = ALTURA;
            }
            //METODOS
            public override float CALCULARAREA()
            {
                return (float)(2 * Math.PI * RADIO * (ALTURA +RADIO));

            }

            public override void ImprimirArea()
            {
                Console.Write("\nAREA DEL CILINDRO: {0}",CALCULARAREA());
            }
            //DESTRUCTOR
            ~CILINDRO() { Console.Write("\nMemoria liberada de la clase CILINDRO"); }
        }

        static void Main(string[] args)
        {
            //declarar varibles

            float RADIO = 0f, ALTURA = 0f;

            //Capturar datos

            Console.Write("RADIO:  ");
            RADIO = float.Parse(Console.ReadLine());

            Console.Write("\nALTURA (SE USUARA PARA CALCULAR EL CILINDRO): ");
            ALTURA = float.Parse(Console.ReadLine());

            //CREAR OBJETOS DE LA CLASE  CIRCULO

            CIRCULO circulo = new CIRCULO(RADIO);

            //IMPRIMIR METODOS DEL OBJETO circulo
            Console.Write("--------------AREA DEL CIRCULO--------------\n");
            Console.Write("\nRADIO: {0}",RADIO);
            circulo.ImprimirArea();

            Console.Write("\nPRECIONE ENTER PARA SEGUIR Y LIMPIAR PANTALLA");
            Console.ReadKey();
            Console.Clear();

            //CREAR OBJETOS DE LA CLASE  ESFERA

            ESFERA esfera = new ESFERA(RADIO);

            //IMPRIMIR METODOS DEL OBJETO esfera
            Console.Write("--------------AREA DE LA ESFERA--------------\n");
            
            Console.Write("\nRADIO: {0}", RADIO);
            esfera.ImprimirArea();

            Console.Write("\nPRECIONE ENTER PARA SEGUIR Y LIMPIAR PANTALLA");
            Console.ReadKey();
            Console.Clear();

            //CREAR OBJETOS DE LA CLASE  CIRCULO

            CILINDRO cilindro = new CILINDRO(ALTURA, RADIO);

            //IMPRIMIR METODOS DEL OBJETO circulo
            Console.Write("--------------AREA DEL CILINDRO--------------\n");
            Console.Write("\nRADIO: {0}", RADIO);
            Console.Write("\nALTURA: {0}", ALTURA);
            cilindro.ImprimirArea();

            Console.Write("\nPRECIONE ENTER PARA SEGUIR Y LIMPIAR PANTALLA");
            Console.ReadKey();
            Console.Clear();

            //IMPRIMIR METODOS

            Console.WriteLine("\nPrecione ENTER para salir");
            Console.ReadKey();
            
        }
    }
}

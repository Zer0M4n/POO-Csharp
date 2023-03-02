using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa16_clase_cliente
{
    internal class Program
    {
        class cliente
        {
            //CAMPOS DE LA CLASE
            private string nombreCliente = "", direccion = "";
            private long telefono = 0;
            private int numeroCliente;

            //Constructor de la clase

            public cliente (string nombreCliente, string direccion , long telefono, int numeroCliente) 
            {
                this.nombreCliente= nombreCliente;
                this.direccion = direccion;
                this.telefono = telefono;
                this.numeroCliente = numeroCliente;
            }

            //metodos

            public float CalcularVenta(float precioProducto, int cantidadVendida)//Funcion de calculo
            {
                 

                return (float)(precioProducto * cantidadVendida);
            }

            public void DesplegarVenta(  float precioProducto, int cantidadVendida )
            {
                Console.Clear();
                Console.Write("El cliente: {0} \nDirrecion: {1}\nTelfono: {2}\nPrecio del producto: c:{3}\nCantidad vendida: {4} \nPrecio final: c:{5} \nNumero del cliente {6}",nombreCliente,direccion,telefono,precioProducto, cantidadVendida, CalcularVenta(precioProducto,cantidadVendida),numeroCliente);
            }
            
            //Desctructoor dde la clase
            ~cliente() { Console.WriteLine("La memoria  a sido LIBERADA"); }
        }
        static void Main(string[] args)
        {
            //DECLARAR VARIABLES
            long telefono = 0;
            string nombreCliente = "", direccion = "";
            int cantidadVendida = 0, numeroCliente = 0;
            float precioProducto = 0f;

            
            //Capturamos datos

            Console.Write("Cual es su nombre ?  ");
            nombreCliente = Console.ReadLine();

            Console.Write("Numero del cliente: ");
            numeroCliente = int.Parse(Console.ReadLine());

            Console.Write("Cuanto deseas de nuestro producto? ");
            cantidadVendida = int.Parse(Console.ReadLine());

            Console.Write("Numero de telefono?  ");
            telefono  = long.Parse(Console.ReadLine());

            Console.Write("Cual es su direccion?  ");
            direccion = Console.ReadLine();

            Console.Write("Cual es el precio?  ");
            precioProducto = float.Parse(Console.ReadLine());

            //Creacion de los objetos

            cliente cliente = new cliente(nombreCliente, direccion, telefono, numeroCliente);

            //DESPLEGAR
            cliente.DesplegarVenta(precioProducto,cantidadVendida);

            Console.Write("\nPrecione ENTER para salir");
            Console.ReadLine();


        }
    }
}

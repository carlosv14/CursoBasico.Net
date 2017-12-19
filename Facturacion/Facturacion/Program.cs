using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion
{
    class Program
    {
        public static int numeroFactura = 1;
        static void Main(string[] args)
        {
            Inventario inventario = new Inventario("Inventario.txt");
            int opcion = 0;
            while (opcion != 5)
            {
                ImprimirMenu();
                Console.Write("Opcion:");
                string eleccion = Console.ReadLine();
                opcion = Convert.ToInt32(eleccion);
                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Cargando inventario...");
                        inventario.Cargar();
                        break;
                    case 2:
                        Console.WriteLine("Ingrese nombre de producto: ");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese precio del producto: ");
                        string precio = Console.ReadLine();
                        double p = Convert.ToDouble(precio);
                        Console.WriteLine("Ingrese cantidad de producto: ");
                        string cantidad = Console.ReadLine();
                        int c = Convert.ToInt32(cantidad);
                        Producto nuevoProducto = new Producto(nombre, p, c);
                        inventario.Modificar(nuevoProducto);
                        break;
                    case 3:
                        Console.WriteLine("-----------Inventario----------");
                        inventario.Imprimir();
                        break;
                    case 4:
                        int opcion3 = 0;
                        while (opcion3 != 4)
                        {
                            Console.WriteLine("Elija el producto a vender: ");
                            inventario.Imprimir();
                            Console.WriteLine("4) Salir");
                            Console.Write("Opcion:");
                            string num2 = Console.ReadLine();
                            opcion3 = Convert.ToInt32(num2);
                            if (opcion3 == 4)
                            {
                                break;
                            }
                            Console.Write("Cantidad de producto: ");
                            string cantidadAVender = Console.ReadLine();
                            int cant = Convert.ToInt32(cantidadAVender);
                            inventario.VenderProducto(opcion3, cant);
                        }
                        break;
                    case 5:
                        inventario.Guardar();
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                break;
            };
           }
        }

        //public static void ImprimirFactura(string [] productosVendidos, int[] cantidadesVendidas, double subtotal, int iterador)
        //{
        //    double impuesto = 0.15;
        //    Console.Write("Ingrese el nombre del cliente: ");
        //    string nombre = Console.ReadLine().ToUpper();
        //    Console.WriteLine("------------Factura " + numeroFactura +" -------------");
        //    Console.WriteLine("Cliente: " + nombre);
        //    Console.WriteLine("Fecha: " + DateTime.Now.ToString("d/M/yyyy"));
        //    for (int i = 0; i < iterador; i++)
        //    {
        //        Console.WriteLine("Producto: " + productosVendidos[i] + " Cantidad: " + cantidadesVendidas[i]);
        //    }
        //    Console.WriteLine("Subtotal: " + subtotal);
        //    double impuestoCalculado = subtotal * impuesto;
        //    Console.WriteLine("Impuesto: " + impuestoCalculado);
        //    double total = subtotal + impuestoCalculado;
        //    Console.WriteLine("Total: " + total);
        //    numeroFactura++;
        //}
      
        public static void ImprimirMenu()
        {
            Console.WriteLine("---------Menu-----------");
            Console.WriteLine("1) Cargar inventario");
            Console.WriteLine("2) Modificar inventario");
            Console.WriteLine("3) Imprimir inventario");
            Console.WriteLine("4) Vender");
            Console.WriteLine("5) Salir");
        } 
    }
}

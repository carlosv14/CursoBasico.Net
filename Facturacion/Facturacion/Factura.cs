using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion
{
    [Serializable]
    public class Factura
    {
        Producto Producto;
        private int Cantidad;
        private double Subtotal;
        private double Total;
        private static int Numero;
        private double Impuesto = 0.15;
        public Factura(Producto producto, int cantidad)
        {
            Producto = producto;
            Cantidad = cantidad;
            Subtotal = cantidad * producto.Precio;
            double impuestoCalculado = Subtotal * Impuesto;
            Total = impuestoCalculado + Subtotal;
            Numero++;
        }

        public void Imprimir()
        {
            Console.Write("Ingrese el nombre del cliente: ");
            string nombre = Console.ReadLine().ToUpper();
            Console.WriteLine("------------Factura " + Numero + " -------------");
            Console.WriteLine("Cliente: " + nombre);
            Console.WriteLine("Fecha: " + DateTime.Now.ToString("d/M/yyyy"));
            Console.WriteLine("Subtotal: " + Subtotal);
            Console.WriteLine("Impuesto: " + (Subtotal * Impuesto));
            Console.WriteLine("total: " + Total);
        }
        public Factura()
        {

        }
    }
}

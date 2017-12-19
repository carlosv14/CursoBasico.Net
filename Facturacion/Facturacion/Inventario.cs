using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Facturacion
{
    class Inventario
    {
        private List<Producto> Productos;
        private string NombreDeArchivo;
        public Inventario(string nombreDeArchivo)
        {
            Productos = new List<Producto>();
            NombreDeArchivo = nombreDeArchivo;
        }

        public void Modificar(Producto producto)
        {
            int encontrado = -1;
            int contador = 0;
            foreach (Producto element in Productos)
            {
                if (element.Nombre == producto.Nombre)
                {
                    encontrado = contador;
                    break;
                }
                contador++;
            }
            if (encontrado != -1)
            {
                Productos[encontrado].Precio = producto.Precio;
                Productos[encontrado].Cantidad = producto.Cantidad;
            }
            else
            {
                Productos.Add(producto);
            }
        }

        public void Cargar()
        {
            XmlSerializer deserializador = new XmlSerializer(typeof(List<Producto>));
            TextReader lector = new StreamReader(NombreDeArchivo);
            Object prods = deserializador.Deserialize(lector);
            Productos = (List<Producto>)prods; 
            lector.Close();
        }
        
        private Producto ObtenerProducto(int posicion)
        {
            if (posicion >=0 && posicion < Productos.Count)
            {
                return Productos[posicion];
            }

            Console.WriteLine("Error!");
            return null;
        }

        public void VenderProducto(int posicion, int cantidad)
        {
            Producto producto = ObtenerProducto(posicion);
            if (producto.Cantidad < cantidad)
            {
                Console.WriteLine("No hay suficiente en inventario, la cantidad que hay es: " + producto.Cantidad);
                return;
            }

            Factura factura = new Factura(producto, cantidad);
            Productos[posicion].Cantidad -= cantidad;
            factura.Imprimir();
        }

        public void Imprimir()
        {
            int contador = 0;
            foreach (var item in Productos)
            {
                Console.WriteLine(contador+ ") Prodcto: " + item.Nombre + " Cantidad: " + item.Cantidad + " Precio: " + item.Precio);
                contador++;
            }
        }
        public void Guardar()
        {
            XmlSerializer serializador = new XmlSerializer(typeof(List<Producto>));
            TextWriter writer = new StreamWriter(NombreDeArchivo);
            serializador.Serialize(writer, Productos);
            writer.Close();
        }
    }
}

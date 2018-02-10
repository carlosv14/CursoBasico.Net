using PuntoDeVenta.BaseDeDatos.Modelos;
using PuntoDeVenta.BaseDeDatos.Repositorios;
using PuntoDeVenta.BaseDeDatos.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta.ConsoleApp
{
    class Program
    {
        static IDbConnectionManager connectionManager = new DbConnectionManager();
        static IRepositorio<Cliente> RepositorioDeClientes = new RepositorioCliente(connectionManager);
        static void Main(string[] args)
        {
            int opcion = 0;
            while (opcion != 5)
            {
                Console.WriteLine("-----------CRUD-------------");
                Console.WriteLine("1) Create ");
                Console.WriteLine("2) Read ");
                Console.WriteLine("3) Update ");
                Console.WriteLine("4) Delete ");
                Console.WriteLine("5) Salir ");
                Console.Write("Opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());
                if (opcion == 2)
                {
                    Read();
                }
                else if (opcion == 1)
                {
                    Create();
                }
                else if (opcion == 3)
                {
                    Update();
                }
                else if (opcion == 4)
                {
                    Delete();
                }
            }

            Console.ReadKey();
        }

        static string ObtenerTabla()
        {
            Console.Write("Ingrese el nombre de la tabla: ");
            string tabla = Console.ReadLine();
            return tabla;
        }
        static void Read()
        {
            string tabla = ObtenerTabla();
            if (tabla.ToLower() == "clientes")
            {
                foreach(var cliente in RepositorioDeClientes.Obtener())
                {
                    Console.WriteLine($"Nombre: {cliente.Nombre} Direccion: {cliente.Direccion}");
                }
            }
        }
        static void Create()
        {
            string tabla = ObtenerTabla();
            if (tabla.ToLower() == "clientes")
            {

                Cliente cliente = new Cliente();
                Console.Write("Ingrese Nombre: ");
                cliente.Nombre = Console.ReadLine();
                Console.Write("Ingrese Direccion: ");
                cliente.Direccion = Console.ReadLine();
                Cliente clienteInsertado = RepositorioDeClientes.Insertar(cliente);
                Console.WriteLine($"Se inserto el cliente con nombre {clienteInsertado.Nombre} y direccion {cliente.Direccion}");
            }
        }

        static void Delete()
        {
            string tabla = ObtenerTabla();
            if (tabla.ToLower() == "clientes")
            {
                Console.Write("Ingrese id: ");
                int id = Convert.ToInt32(Console.ReadLine());
                Cliente clienteInsertado = RepositorioDeClientes.Borrar(id);
            }
        }
        static void Update()
        {
            string tabla = ObtenerTabla();
            if (tabla.ToLower() == "clientes")
            {

                Cliente cliente = new Cliente();
                Console.Write("Ingrese Id: ");
                cliente.Id = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese Nombre: ");
                cliente.Nombre = Console.ReadLine();
                Console.Write("Ingrese Direccion: ");
                cliente.Direccion = Console.ReadLine();
                Cliente clienteInsertado = RepositorioDeClientes.Actualizar(cliente);
                Console.WriteLine($"Se actualizó el cliente con nombre {clienteInsertado.Nombre} y direccion {cliente.Direccion}");
            }
        }
    }
}

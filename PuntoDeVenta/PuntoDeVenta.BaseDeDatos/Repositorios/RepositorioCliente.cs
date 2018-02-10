using PuntoDeVenta.BaseDeDatos.Modelos;
using PuntoDeVenta.BaseDeDatos.Utilidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta.BaseDeDatos.Repositorios
{
    public class RepositorioCliente : IRepositorio<Cliente>
    {
        private readonly IDbConnectionManager connectionManager;

        public RepositorioCliente(IDbConnectionManager connectionManager)
        {
            this.connectionManager = connectionManager;
        }
        public List<Cliente> Obtener()
        {
            List<Cliente> clientes = new List<Cliente>();
            using (var conexion = this.connectionManager.ObtenerConexion())
            {
                conexion.Open();
                string query = "Select Id, Nombre, Direccion from Clientes;";
                using (var cmd = new SqlCommand(query, conexion))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            clientes.Add(new Cliente {Id = reader.GetInt32(0), Nombre = reader.GetString(1), Direccion = reader.GetString(2)});
                        }
                    }
                }
                conexion.Close();
            }

            return clientes;
        }

        public Cliente Insertar(Cliente entidad)
        {
            string query = "INSERT INTO Clientes VALUES(";
            query += "'"+ entidad.Nombre + "',";
            query += "'" + entidad.Direccion + "')";
            this.connectionManager.EjecutarComando(query);
            return entidad;
        }

        public Cliente Actualizar(Cliente entidad)
        {
            using (var conexion = this.connectionManager.ObtenerConexion())
            {
                conexion.Open();
                using (var command = new SqlCommand("uspActualizarCliente", conexion))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@Id", entidad.Id));
                    command.Parameters.Add(new SqlParameter("@Nombre", entidad.Nombre));
                    command.Parameters.Add(new SqlParameter("@Direccion", entidad.Direccion));

                    command.ExecuteNonQuery();
                }
                conexion.Close();
            }
            return entidad;
        }

        public Cliente Borrar(int id)
        {
            string query = "DELETE FROM Clientes WHERE Id = " + id;
            this.connectionManager.EjecutarComando(query);
            return null;
        }
    }
}

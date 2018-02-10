using PuntoDeVenta.BaseDeDatos.Properties;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta.BaseDeDatos.Utilidades
{
    public class DbConnectionManager : IDbConnectionManager
    {
        public virtual void EjecutarComando(string query)
        {
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();
                using (var command = new SqlCommand(query, conexion))
                {
                    command.ExecuteNonQuery();
                }
                conexion.Close();
            }
        }
        public virtual SqlConnection ObtenerConexion()
        {
            return new SqlConnection(Settings.Default.ConnectionString);
        }
    }
}

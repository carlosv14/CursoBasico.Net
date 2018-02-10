using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta.BaseDeDatos.Utilidades
{
    public interface IDbConnectionManager
    {
        SqlConnection ObtenerConexion();

        void EjecutarComando(string query);

    }
}

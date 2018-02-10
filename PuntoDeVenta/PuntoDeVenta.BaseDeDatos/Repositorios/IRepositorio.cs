using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta.BaseDeDatos.Repositorios
{
    public interface IRepositorio<TEntity>
    {
        List<TEntity> Obtener();

        TEntity Insertar(TEntity entidad);

        TEntity Actualizar(TEntity entidad);

        TEntity Borrar(int id);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta.BaseDeDatos.Modelos
{
    public class Factura
    {
        public int Id { get; set; }

        public int IdCliente { get; set; }

        public DateTime Fecha { get; set; }
    }
}

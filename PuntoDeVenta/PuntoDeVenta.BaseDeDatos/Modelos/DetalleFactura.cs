using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta.BaseDeDatos.Modelos
{
    public class DetalleFactura
    {
        public int CodigoFactura { get; set; }

        public int CodigoProducto { get; set; }

        public int Cantidad { get; set; }
    }
}

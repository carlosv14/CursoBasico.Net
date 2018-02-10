using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta.BaseDeDatos.Modelos
{
    public class Producto
    {
        public int Id { get; set; }

        public string  Descripcion { get; set; }

        public float Precio { get; set; }
    }
}

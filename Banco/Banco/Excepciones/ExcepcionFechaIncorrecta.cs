using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Excepciones
{
    public class ExcepcionFechaIncorrecta : Exception
    {
        public ExcepcionFechaIncorrecta(DateTime fecha) : base("No se puede retirar antes de: " + fecha)
        {

        }
    }
}

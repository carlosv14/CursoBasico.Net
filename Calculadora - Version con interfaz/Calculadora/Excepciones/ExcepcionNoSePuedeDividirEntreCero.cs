using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Excepciones
{
    public class ExcepcionNoSePuedeDividirEntreCero : Exception
    {
        public ExcepcionNoSePuedeDividirEntreCero(string message) : base(message)
        {

        }
    }
}

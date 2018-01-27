using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Excepciones
{
    public class ExcepcionSaldoInsuficiente : Exception
    {
        public ExcepcionSaldoInsuficiente(double retiro, double disponible) : base("No se puede realizar el retiro de: " + retiro + " porque su saldo es de: " + disponible)
        {

        }
    }
}

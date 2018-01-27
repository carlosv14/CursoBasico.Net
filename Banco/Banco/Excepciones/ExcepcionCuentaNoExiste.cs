using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Excepciones
{
    public class ExcepcionCuentaNoExiste : Exception
    {
        public ExcepcionCuentaNoExiste(int numeroCuenta) : base("La cuenta "+ numeroCuenta + " no existe")
        {
            
        }
    }
}

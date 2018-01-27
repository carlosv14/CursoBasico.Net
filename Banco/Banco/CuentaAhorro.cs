using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class CuentaAhorro : Cuenta
    {
        public CuentaAhorro(double cantidadInicial, int id)
        {
            this.id = id;
            this.saldo = cantidadInicial;
        }

        public override void Retirar(double cantidad)
        {
            if (this.saldo < cantidad)
            {
                throw new Excepciones.ExcepcionSaldoInsuficiente(cantidad, this.saldo);
            }

            this.saldo -= cantidad;
        }
    }
}

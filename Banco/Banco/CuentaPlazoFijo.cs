using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class CuentaPlazoFijo : Cuenta
    {
        public DateTime fechaRetiro;
        public CuentaPlazoFijo(double cantidad, int id)
        {
            this.id = id;
            this.saldo = cantidad;
            this.fechaRetiro = DateTime.Today.AddYears(1);
        }
        public override void Retirar(double cantidad)
        {
            if (this.saldo < cantidad)
            {
                throw new Excepciones.ExcepcionSaldoInsuficiente(cantidad, this.saldo);
            }
            if (this.fechaRetiro > DateTime.Today)
            {
                throw new Excepciones.ExcepcionFechaIncorrecta(this.fechaRetiro);
            }
            this.saldo -= cantidad;
        }
    }
}

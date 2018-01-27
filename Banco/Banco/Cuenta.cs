using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public abstract class Cuenta : IRetirable, IDepositable
    {
        public double saldo;
        public int id;
        
        public virtual void Depositar(double cantidad)
        {
            this.saldo += cantidad;
        }
        public abstract void Retirar(double cantidad);
    }
}

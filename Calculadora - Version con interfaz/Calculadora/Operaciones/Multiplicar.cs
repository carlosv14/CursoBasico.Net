using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Operaciones
{
    public class Multiplicar : Operacion
    {
        public Multiplicar(int izquierda, int derecha)
        {
            this.Derecha = derecha;
            this.Izquierda = izquierda;
        }
        public override double Operar()
        {
            return this.Izquierda * this.Derecha;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Operaciones
{
    public class Restar : Operacion
    {
        public Restar(int izquierda, int derecha)
        {
            this.Izquierda = izquierda;
            this.Derecha = derecha;
        }
        public override double Operar()
        {
            return this.Izquierda - this.Derecha;
        }
    }
}

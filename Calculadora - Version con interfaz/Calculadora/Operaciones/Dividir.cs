using Calculadora.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Operaciones
{
    public class Dividir : Operacion
    {
        public Dividir(int izquierda, int derecha)
        {
            this.Izquierda = izquierda;
            this.Derecha = derecha;
        }

        public override double Operar()
        {
            if (this.Derecha == 0)
            {
                throw new ExcepcionNoSePuedeDividirEntreCero("No se puede dividir el número " + this.Izquierda + " entre 0");
            }
            return this.Izquierda / this.Derecha;
        }
    }
}

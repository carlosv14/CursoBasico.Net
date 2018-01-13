using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Triangulo : Figura
    {
        public int basex;
        public int altura;
        public Triangulo(int x, int y, int basex, int altura) : base(x,y)
        {
            this.basex = basex;
            this.altura = altura;
        }

        public override double CalcularArea()
        {
            return this.basex * altura;
        }

        public override string ObtenerNombre()
        {
            return "Triangulo";
        }
    }
}

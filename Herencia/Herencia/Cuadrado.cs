using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Cuadrado : Figura
    {
        public int lado1;
        public int lado2;
        public Cuadrado(int x, int y, int lado1, int lado2) : base(x, y)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
        }

        public override double CalcularArea()
        {
            return lado1 * lado2;
        }

        public override void Dibujar()
        {
            Console.WriteLine("Dibujando cuadrado en la posicion x= " + this.x + " y= " + this.y);
        }

    }
}

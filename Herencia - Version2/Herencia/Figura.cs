using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Figura
    {
        public int y;
        public int x;
        public Figura(int x, int y)
        {
            this.x = x;
            this.y = y;
            Console.WriteLine("Cree una figura");
        }

        public virtual double CalcularArea()
        {
            return 0;
        }

        public virtual string ObtenerNombre()
        {
            return "Figura";
        }
        public virtual void Dibujar()
        {
            Console.WriteLine($"Dibujando {ObtenerNombre()} en la posicion x= " + this.x + " y= " + this.y );
        }
    }
}

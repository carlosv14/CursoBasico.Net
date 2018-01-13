using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.Animales
{
    public class Pollo : Animal
    {
        public Pollo()
        {
            Console.WriteLine($"Se ha creado un {this.ObtenerNombre()}");
        }
        public override string ObtenerSonido()
        {
           return "Pio Pio";
        }

        public override string ObtenerNombre()
        {
            return "Pollo";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.Animales
{
    public class Perro : Animal
    {
        public Perro()
        {
            Console.WriteLine($"Se ha creado un {this.ObtenerNombre()}");
        }
        public override string ObtenerSonido()
        {
            return "Wuff Wuff";
        }

        public override string ObtenerNombre()
        {
            return "Perro";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.Animales
{
    public class Perro : Animal
    {
        public override string ObtenerNombre()
        {
            return "Perro";
        }

        public override string ObtenerSonido()
        {
            return "Wuf wuf";
        }
    }
}

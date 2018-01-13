using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.Animales
{
    public class Animal
    {
        public virtual string ObtenerNombre()
        {
            return "";
        }

        public virtual string ObtenerSonido()
        {
            return "";
        }
    }
}

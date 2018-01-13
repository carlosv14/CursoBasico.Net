using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.Animales
{
    public class Granja
    {
        private List<Animal> Animales;

        public Granja()
        {
            this.Animales = new List<Animal>();
            this.Animales.Add(new Perro());
            this.Animales.Add(new Pollo());
            this.Animales.Add(new Animal());
        }

        public void ImprimirAnimales()
        {
            foreach (var animal in this.Animales)
            {
                Console.WriteLine($"El {animal.ObtenerNombre()} hace '{animal.ObtenerSonido()}' ");
            }
        }


    }
}

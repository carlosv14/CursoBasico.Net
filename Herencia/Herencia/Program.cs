using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Program
    {   
        static void Main(string[] args)
        {
            Animales.Granja granja = new Animales.Granja();
            granja.ImprimirAnimales();
            Console.ReadKey();
        }
    }
}

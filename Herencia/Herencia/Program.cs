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
            Figura figura = new Figura(3,4);
            double area = figura.CalcularArea();
            
            Console.WriteLine("El area de la figura es: " + area);
            figura.Dibujar();

            Console.WriteLine("---------------------------------");

            Cuadrado cuadrado = new Cuadrado(5, 6,5,5);
            area = cuadrado.CalcularArea();
            Console.WriteLine("El area de el cuadrado es: " + area);
            cuadrado.Dibujar();
            Console.ReadKey();
        }
    }
}

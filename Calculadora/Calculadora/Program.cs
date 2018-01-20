using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora.ImprimirOpciones();
            Console.Write("Opcion: ");
            int opcion = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese primer numero: ");
            int izquierda = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese segundo numero: ");
            int derecha = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"La resupuesta es: {Calculadora.Calcular(opcion, izquierda, derecha)}");
            Console.ReadKey();
        }
    }
}

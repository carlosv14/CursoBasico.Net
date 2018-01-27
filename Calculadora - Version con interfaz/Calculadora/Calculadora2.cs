using Calculadora.Operaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Calculadora2 : ICalculable
    {
        private List<string> operaciones = new List<string>()
        {
            "Multiplicar",
            "Dividir"
        };
        public double Calcular(int opcion)
        {
            switch (opcion)
            {
                case 0:
                    Console.Write("Ingrese primer numero: ");
                    int izquierda = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Ingrese segundo numero: ");
                    int derecha = Convert.ToInt32(Console.ReadLine());
                    Multiplicar multiplicacion = new Multiplicar(izquierda, derecha);
                    return multiplicacion.Operar();
                case 1:
                    Console.Write("Ingrese primer numero: ");
                    izquierda = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Ingrese segundo numero: ");
                    derecha = Convert.ToInt32(Console.ReadLine());
                    Dividir division = new Dividir(izquierda, derecha);
                    return division.Operar();
                default:
                    throw new Excepciones.ExcepcionOperacionInvalida("La operacion con numero " + opcion + " es invalida");
            }

        }

        public void ImprimirOpciones()
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"{i}) {operaciones[i]}");
            }
        }
    }
}

using Calculadora.Operaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public static class Calculadora
    {
        private static List<string> operaciones = new List<string>()
        {
            "Sumar",
            "Restar",
            "Multiplicar",
            "Dividir"
        };
        public static void ImprimirOpciones()
        {
            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine($"{i}) {operaciones[i]}");
            }
        }

        public static double Calcular(int opcion, int izquierda, int derecha)
        {
            switch (opcion)
            {
                case 0:
                    Sumar suma = new Sumar(izquierda, derecha);
                    return suma.Operar();
                case 1:
                    Restar resta = new Restar(izquierda, derecha);
                    return resta.Operar();
                case 2:
                    Multiplicar multiplicacion = new Multiplicar(izquierda, derecha);
                    return multiplicacion.Operar();
                case 3:
                    Dividir division = new Dividir(izquierda, derecha);
                    return division.Operar();
                default:
                    return double.NaN;
            }
        }
    }
}

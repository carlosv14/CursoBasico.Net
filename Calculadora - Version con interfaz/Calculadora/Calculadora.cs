using Calculadora.Operaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Calculadora : ICalculable
    {
        private List<string> operaciones = new List<string>()
        {
            "Sumar",
            "Restar"
        };
        public void ImprimirOpciones()
        {
            for(int i = 0; i < 2; i++)
            {
                Console.WriteLine($"{i}) {operaciones[i]}");
            }
        }

        public  double Calcular(int opcion)
        {
            try
            {
                switch (opcion)
                {
                    case 0:
                        Console.Write("Ingrese primer numero: ");
                        int izquierda = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Ingrese segundo numero: ");
                        int derecha = Convert.ToInt32(Console.ReadLine());
                        Sumar suma = new Sumar(izquierda, derecha);
                        return suma.Operar();
                    case 1:
                        Console.Write("Ingrese primer numero: ");
                        izquierda = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Ingrese segundo numero: ");
                        derecha = Convert.ToInt32(Console.ReadLine());
                        Restar resta = new Restar(izquierda, derecha);
                        return resta.Operar();

                    default:
                        throw new Excepciones.ExcepcionOperacionInvalida("La operacion con numero " + opcion + " es invalida");
                }
            }
            catch (FormatException)
            {
                throw new Exception("Se ingreso una letra en lugar de un numero");
            }
        }
    }
}

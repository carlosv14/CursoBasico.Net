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

        public  double Calcular(int opcion, int izquierda, int derecha)
        {
            switch (opcion)
            {
                case 0:
                    Sumar suma = new Sumar(izquierda, derecha);
                    return suma.Operar();
                case 1:
                    Restar resta = new Restar(izquierda, derecha);
                    return resta.Operar();
               
                default:
                    throw new Excepciones.ExcepcionOperacionInvalida("La operacion con numero " + opcion + " es invalida");
            }
        }
    }
}

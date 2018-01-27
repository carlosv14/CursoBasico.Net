using Calculadora.Operaciones;
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
            try
            {
                ICalculable calculadora = null;
                int op = 0;
                while (true)
                {
                    Console.WriteLine("Presione 1 para sumas y restas, presione 2 para mulplicaciones y divisiones");
                    Console.Write("Opcion ");
                    op = Convert.ToInt32(Console.ReadLine());
                    if (op == 1)
                    {
                        calculadora = new Calculadora();
                    }
                    else if (op == 2)
                    {
                        calculadora = new Calculadora2();
                    }
                    calculadora.ImprimirOpciones();
                    Console.Write("Opcion: ");
                    int opcion = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Ingrese primer numero: ");
                    int izquierda = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Ingrese segundo numero: ");
                    int derecha = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"La resupuesta es: {calculadora.Calcular(opcion, izquierda, derecha)}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
            Console.ReadKey();
        }
    }
}

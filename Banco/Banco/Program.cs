using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    ImprimirOpciones();
                    Console.Write("Opcion: ");
                    int opcion = Convert.ToInt32(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            Banco.CrearCuenta();
                            break;
                        case 2:
                            Banco.Depositar();
                            break;
                        case 3:
                            Banco.Retirar();
                            break;
                        case 4:
                            Banco.MostrarSaldo();
                            break;
                        default:
                            Console.WriteLine("Opcion no valida");
                            break;
                    }

                }
                catch (Exception e)
                {
                    if (e.GetType() == typeof(FormatException))
                    {
                        Console.WriteLine("Ingrese un numero valido");
                    }
                    else
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
        }

        static void ImprimirOpciones()
        {
            Console.WriteLine("1) Crear cuenta");
            Console.WriteLine("2) Depositar");
            Console.WriteLine("3) Retirar");
            Console.WriteLine("4) Ver saldo");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public static class Banco
    {
        private static  int id = 0;
        private static List<Cuenta> cuentas = new List<Cuenta>();
        public static void CrearCuenta()
        {
            Console.WriteLine("Ingrese el tipo de cuenta: ");
            Console.Write("Tipo de cuenta: ");
            int opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Ingrese la cantidad inicial de su cuenta: ");
                    Console.Write("Cantidad: ");
                    double cantidadInicial = Convert.ToDouble(Console.ReadLine());
                    cuentas.Add(new CuentaAhorro(cantidadInicial, id));
                    id++;
                    break;
                case 2:
                    Console.WriteLine("Ingrese la cantidad inicial de su cuenta: ");
                    Console.Write("Cantidad: ");
                    cantidadInicial = Convert.ToDouble(Console.ReadLine());
                    cuentas.Add(new CuentaPlazoFijo(cantidadInicial, id));
                    id++;
                    break;
                default:
                    break;
            }
        }

        private static int BuscarCuenta(int numeroDeCuenta)
        {
            for (int i = 0; i < cuentas.Count; i++)
            {
                if (cuentas[i].id == numeroDeCuenta)
                {
                    return i;
                }
            }

            throw new Excepciones.ExcepcionCuentaNoExiste(numeroDeCuenta);
        }
        public static void Depositar()
        {
            Console.WriteLine("Ingrese su numero de cuenta: ");
            Console.Write("Numero de cuenta: ");
            int opcion = Convert.ToInt32(Console.ReadLine());
            int cuenta = BuscarCuenta(opcion);
            Console.WriteLine("Ingrese la cantidad que desea depositar: ");
            Console.Write("Cantidad: ");
            double cantidad = Convert.ToDouble(Console.ReadLine());
            cuentas[cuenta].Depositar(cantidad);
        }

        public static void Retirar()
        {
            Console.WriteLine("Ingrese su numero de cuenta: ");
            Console.Write("Numero de cuenta: ");
            int opcion = Convert.ToInt32(Console.ReadLine());
            int cuenta = BuscarCuenta(opcion);
            Console.WriteLine("Ingrese la cantidad que desea retirar: ");
            Console.Write("Cantidad: ");
            double cantidad = Convert.ToDouble(Console.ReadLine());
            cuentas[cuenta].Retirar(cantidad);
        }

        public static void MostrarSaldo()
        {
            Console.WriteLine("Ingrese su numero de cuenta: ");
            Console.Write("Numero de cuenta: ");
            int opcion = Convert.ToInt32(Console.ReadLine());
            int cuenta = BuscarCuenta(opcion);
            Console.WriteLine($"El saldo de su cuenta es: {cuentas[cuenta].saldo}");
        }
    }
}

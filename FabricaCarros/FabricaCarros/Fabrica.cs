using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaCarros
{
    public static class Fabrica
    {
        private static List<Carro> Carros = new List<Carro>();

        public static void ListarMarcas()
        {
            Console.WriteLine("0) Toyota");
            Console.WriteLine("1) Mercedes");
        }

        public static void CrearCarro(int opcion, string color)
        {
            if (opcion == 0)
            {
                Carros.Add(new Toyota(color));
            }
            else if (opcion == 1)
            {
                Carros.Add(new Mercedes(color));
            }
        }

        public static void ImprimirCarros()
        {
            foreach (var carro in Carros)
            {
                carro.Imprimir();
            }
        }
    }
}

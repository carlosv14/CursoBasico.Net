using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaCarros
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            while (contador < 3)
            {
                Fabrica.ListarMarcas();
                Console.Write("Opcion: ");
                int opcion = Convert.ToInt32(Console.ReadLine());
                Console.Write("Escriba el color: ");
                string color = Console.ReadLine();
                Fabrica.CrearCarro(opcion, color);
                contador++;
            }
            Fabrica.ImprimirCarros();
            Console.ReadKey();
          

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int divisor = 5;
                for (int i = 0; i < 5; i++)
                {
                    divisor = divisor - 1;
                    if (divisor == 0)
                    {
                        throw new Exception("No es posible dividir entre 0");
                    }
                    Console.WriteLine(5 / divisor);
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

static void Main(string[] args)
        {

            int[] arreglo = {25,12,10,6,5,3,78,20};
            Console.Write("Elija el numero a buscar: ");
            string txtNumero = Console.ReadLine();
            int num = Convert.ToInt32(txtNumero);
            bool encontrado = false;
            foreach (int element in arreglo)
            {
                if (element == num)
                {
                    encontrado = true;
                    break;
                }
            }
            if (encontrado == true)
            {
                Console.WriteLine("Si existe");
            }
            else
            {
                Console.WriteLine("No existe");
            }
            Console.ReadKey();
        }

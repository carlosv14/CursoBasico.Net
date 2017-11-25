   class Program
    {
        static void Main(string[] args)
        {
            //Cantidad de veces que se repite un numero
            int[] arr = new int[5] {1,1,3,1,5};
            //Console.WriteLine("Ingrese el numero a buscar");
            //string numero = Console.ReadLine();
            //int num = Convert.ToInt32(numero);

            //int cantidad = 0;
            //foreach (var item in arr)
            //{
            //    if (item == num)
            //    {
            //        cantidad++;
            //    }
            //}

            //Console.WriteLine("Se repite: " + cantidad + " veces");

            //Calcular la media de los numeros
            float cantidad = 0;
            float suma = 0;

            foreach (var item in arr)
            {
                suma += item;
                cantidad++;
            }

            float promedio = suma / cantidad;
            Console.WriteLine("Promedio: " + promedio);

            Console.ReadKey();

        }
    }

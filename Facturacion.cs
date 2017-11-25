 class Program
    {
        public static string[] frutas = new string[4];
        public static int[] cantidades = new int[4];
        public static double[] precios = new double[4];
        public static int numeroFactura = 1;
        static void Main(string[] args)
        {
            int opcion = 0;

            while (opcion != 5)
            {
                ImprimirMenu();
                Console.Write("Opcion:");
                string eleccion = Console.ReadLine();
                opcion = Convert.ToInt32(eleccion);
                Console.Clear();
                if (opcion == 1)
                {
                    Console.WriteLine("Cargando inventario...");
                    CargarInventario("Inventario.txt");
                }
                else if (opcion == 2)
                {
                    int opcion2 = 0;
                    Console.WriteLine("Elija el producto a modificar: ");
                    ImprimirProductos();
                    Console.Write("Opcion:");
                    string num = Console.ReadLine();
                    opcion2 = Convert.ToInt32(num);
                    if (opcion2 < 4 && opcion2 >= 0)
                    {
                        Console.WriteLine("Cantidad de producto nueva: ");
                        string cantidad = Console.ReadLine();
                        Console.WriteLine("Precio nuevo: ");
                        string precio = Console.ReadLine();
                        cantidades[opcion2] = Convert.ToInt32(cantidad);
                        precios[opcion2] = Convert.ToDouble(precio);
                    }
                }
                else if (opcion == 3)
                {
                    Console.WriteLine("-----------Inventario----------");
                    ImprimirInventario();
                }
                else if (opcion == 4)
                {
                    int opcion2 = 0;
                    double subtotal = 0;
                    string[] productosVendidos = new string[4];
                    int iterador = 0;
                    int[] cantidadesVendidas = new int[4];
                    while (opcion2 != 4)
                    {
                        Console.WriteLine("Elija el producto a vender: ");
                        ImprimirProductos();
                        Console.WriteLine("4) Salir");
                        Console.Write("Opcion:");
                        string num = Console.ReadLine();
                        opcion2 = Convert.ToInt32(num);
                        if (opcion2 < 4 && opcion2 >= 0)
                        {
                            Console.Write("Cantidad de producto: ");
                            string cantidad = Console.ReadLine();
                            int cant = Convert.ToInt32(cantidad);
                            if (cant > cantidades[opcion2])
                            {
                                Console.WriteLine("No hay suficiente en inventario, la cantidad que hay es: " + cantidades[opcion2]);
                            }
                            else
                            {
                                productosVendidos[iterador] = frutas[opcion2];
                                cantidadesVendidas[iterador] = cant;
                                iterador++;
                                cantidades[opcion2] -= cant;
                                subtotal += (cant * precios[opcion2]);
                            }
                        }
                    }

                    ImprimirFactura(productosVendidos, cantidadesVendidas, subtotal, iterador);
                   
                }
                else if (opcion == 5)
                {
                    GuardarCambios("Inventario.txt");
                }
            }
        }

        public static void ImprimirFactura(string [] productosVendidos, int[] cantidadesVendidas, double subtotal, int iterador)
        {
            double impuesto = 0.15;
            Console.Write("Ingrese el nombre del cliente: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("------------Factura " + numeroFactura +" -------------");
            Console.WriteLine("Cliente: " + nombre);
            Console.WriteLine("Fecha: " + DateTime.Now);
            for (int i = 0; i < iterador; i++)
            {
                Console.WriteLine("Producto: " + productosVendidos[i] + " Cantidad: " + cantidadesVendidas[i]);
            }
            Console.WriteLine("Subtotal: " + subtotal);
            double impuestoCalculado = subtotal * impuesto;
            Console.WriteLine("Impuesto: " + impuestoCalculado);
            double total = subtotal + impuestoCalculado;
            Console.WriteLine("Total: " + total);
            numeroFactura++;
        }
        public static void GuardarCambios(string nombreDeArchivo)
        {
            string contenidoArchivo = "";
            for (int i = 0; i < 4; i++)
            {
                if (i == 3)
                {
                    contenidoArchivo += frutas[i] + ":" + cantidades[i] + ":" + precios[i];
                }
                else
                {
                    contenidoArchivo += frutas[i] + ":" + cantidades[i] + ":" + precios[i] + ";";
                }
            }
            File.WriteAllText(nombreDeArchivo,contenidoArchivo);
        }

        public static void ImprimirInventario()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Producto: " + frutas[i] + " Cantidad: " + cantidades[i] + " Precio: " + precios[i]);
            }
        }

        public static void ImprimirProductos()
        {
            Console.WriteLine("0) " + frutas[0]);
            Console.WriteLine("1) " + frutas[1]);
            Console.WriteLine("2) " + frutas[2]);
            Console.WriteLine("3) " + frutas[3]);
        }

        public static void CargarInventario(string nombreDeArchivo)
        {
            string inventario = File.ReadAllText(nombreDeArchivo);
            string[] informacionDeProductos = inventario.Split(';');
            string[] contenido;
            int numero = 0;
            int iterador = 0;
            foreach (var item in informacionDeProductos)
            {
                contenido = item.Split(':');
                foreach (var item2 in contenido)
                {
                    if (numero == 0)
                    {
                        frutas[iterador] = item2;
                    }
                    if (numero == 1)
                    {
                        cantidades[iterador] = Convert.ToInt32(item2);
                    }
                    if (numero == 2)
                    {
                        precios[iterador] = Convert.ToDouble(item2);
                    }
                    numero++;
                    if (numero == 3)
                    {
                        numero = 0;
                        iterador++;
                    }
                }
            }
        }
        public static void ImprimirMenu()
        {
            Console.WriteLine("---------Menu-----------");
            Console.WriteLine("1) Cargar inventario");
            Console.WriteLine("2) Modificar inventario");
            Console.WriteLine("3) Imprimir inventario");
            Console.WriteLine("4) Vender");
            Console.WriteLine("5) Salir");
        } 
    }

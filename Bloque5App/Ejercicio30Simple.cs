using System;

class Ejercicio30Simple
{
    public static void Ejecutar()
    {
        string[] nombres = new string[5];
        int[] codigos = new int[5];
        int[] cantidades = new int[5];
        double[] precios = new double[5];

        Console.WriteLine("--- REGISTRO DE 5 PRODUCTOS ---");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"\nProducto #{i + 1}:");

            Console.Write("Nombre: ");
            nombres[i] = Console.ReadLine();

            Console.Write("Codigo numerico: ");
            codigos[i] = int.Parse(Console.ReadLine());

            Console.Write("Cantidad: ");
            cantidades[i] = int.Parse(Console.ReadLine());

            Console.Write("Precio: ");
            precios[i] = double.Parse(Console.ReadLine());
        }

        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("\n--- INVENTARIO ---");
            Console.WriteLine("1. Mostrar Inventario");
            Console.WriteLine("2. Buscar Producto por codigo");
            Console.WriteLine("3. Actualizar cantidad");
            Console.WriteLine("4. Valor total del inventario");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione opcion: ");
            string opcion = Console.ReadLine();

            if (opcion == "1")
            {
                Console.WriteLine("\nCODIGO\tNOMBRE\tCANT.\tPRECIO\tSUBTOTAL");
                for (int i = 0; i < 5; i++)
                {
                    double subtotal = cantidades[i] * precios[i];
                    Console.WriteLine($"{codigos[i]}\t{nombres[i]}\t{cantidades[i]}\t{precios[i]}\t{subtotal}");
                }
            }
            else if (opcion == "2")
            {
                Console.Write("Ingrese codigo a buscar: ");
                int buscarCod = int.Parse(Console.ReadLine());
                int indice = BuscarPorCodigo(codigos, buscarCod);
                if (indice != -1)
                    Console.WriteLine($"Encontrado: {nombres[indice]} - Stock: {cantidades[indice]}");
                else
                    Console.WriteLine("Producto no encontrado.");
            }
            else if (opcion == "3")
            {
                Console.Write("Codigo del producto a actualizar: ");
                int actCod = int.Parse(Console.ReadLine());
                int idx = BuscarPorCodigo(codigos, actCod);
                if (idx != -1)
                {
                    Console.Write($"Nueva cantidad para {nombres[idx]}: ");
                    cantidades[idx] = int.Parse(Console.ReadLine());
                    Console.WriteLine("Inventario actualizado.");
                }
                else
                    Console.WriteLine("Producto no encontrado.");
            }
            else if (opcion == "4")
            {
                double total = 0;
                for (int i = 0; i < 5; i++)
                    total += cantidades[i] * precios[i];
                Console.WriteLine($"Valor total del inventario: {total}");
            }
            else if (opcion == "5")
            {
                salir = true;
            }
            else
            {
                Console.WriteLine("Opcion no valida, intente de nuevo.");
            }
        }
    }

    private static int BuscarPorCodigo(int[] codigos, int codigo)
    {
        for (int i = 0; i < 5; i++)
        {
            if (codigos[i] == codigo)
                return i;
        }
        return -1;
    }
}

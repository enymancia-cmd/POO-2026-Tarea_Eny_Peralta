using System;

class Ejercicio25Rotacion
{
    public static void Ejecutar()
    {
        Console.Write("Ingrese tamaño del arreglo: ");
        int n = int.Parse(Console.ReadLine());

        int[] arreglo = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Ingrese valor #" + (i + 1) + ": ");
            arreglo[i] = int.Parse(Console.ReadLine());
        }

        int opcion;
        do
        {
            Console.WriteLine("1. Rotar K posiciones a la izquierda");
            Console.WriteLine("2. Rotar K posiciones a la derecha");
            Console.WriteLine("3. Invertir arreglo");
            Console.WriteLine("4. Mostrar arreglo");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione opcion: ");
            opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                Console.Write("Ingrese K: ");
                int k = int.Parse(Console.ReadLine());
                for (int i = 0; i < k; i++)
                {
                    int temp = arreglo[0];
                    for (int j = 0; j < n - 1; j++)
                        arreglo[j] = arreglo[j + 1];
                    arreglo[n - 1] = temp;
                }
                Console.WriteLine("Arreglo rotado a la izquierda");
            }
            else if (opcion == 2)
            {
                Console.Write("Ingrese K: ");
                int k = int.Parse(Console.ReadLine());
                for (int i = 0; i < k; i++)
                {
                    int temp = arreglo[n - 1];
                    for (int j = n - 1; j > 0; j--)
                        arreglo[j] = arreglo[j - 1];
                    arreglo[0] = temp;
                }
                Console.WriteLine("Arreglo rotado a la derecha");
            }
            else if (opcion == 3)
            {
                for (int i = 0; i < n / 2; i++)
                {
                    int temp = arreglo[i];
                    arreglo[i] = arreglo[n - 1 - i];
                    arreglo[n - 1 - i] = temp;
                }
                Console.WriteLine("Arreglo invertido");
            }
            else if (opcion == 4)
            {
                Console.WriteLine("Contenido del arreglo:");
                for (int i = 0; i < n; i++)
                    Console.Write(arreglo[i] + " ");
                Console.WriteLine();
            }
        } while (opcion != 0);
    }
}

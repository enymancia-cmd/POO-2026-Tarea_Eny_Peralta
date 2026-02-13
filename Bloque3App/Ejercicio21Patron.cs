using System;

class Ejercicio21Patron
{
    public static void Ejecutar()
    {
        Console.Write("Tamaño: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("1. Triangulo");
        Console.WriteLine("2. Triangulo invertido");
        int op = int.Parse(Console.ReadLine());

        if (op == 1)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write("*");

                Console.WriteLine();
            }
        }
        else
        {
            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write("*");

                Console.WriteLine();
            }
        }
    }
}

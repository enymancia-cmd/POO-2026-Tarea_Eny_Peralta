using System;

class Ejercicio17Fibonacci
{
    public static void Ejecutar()
    {
        Console.Write("Cantidad terminos: ");
        int n = int.Parse(Console.ReadLine());

        int a = 0;
        int b = 1;
        int suma = 0;

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(a);
            suma += a;

            int siguiente = a + b;
            a = b;
            b = siguiente;
        }

        Console.WriteLine("Suma: " + suma);
        Console.WriteLine("Promedio: " + (double)suma / n);
    }
}

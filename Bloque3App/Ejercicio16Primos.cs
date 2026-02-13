using System;

class Ejercicio16Primos
{
    public static void Ejecutar()
    {
        Console.Write("Inicio rango: ");
        int inicio = int.Parse(Console.ReadLine());

        Console.Write("Fin rango: ");
        int fin = int.Parse(Console.ReadLine());

        int contador = 0;

        for (int num = inicio; num <= fin; num++)
        {
            int divisores = 0;

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                    divisores++;
            }

            if (divisores == 2)
            {
                Console.WriteLine(num);
                contador++;
            }
        }

        Console.WriteLine("Cantidad primos: " + contador);
    }
}

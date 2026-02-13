using System;

class Ejercicio26Frecuencia
{
    public static void Ejecutar()
    {
        int[] numeros = new int[20];
        Random rnd = new Random();

        for (int i = 0; i < 20; i++)
        {
            numeros[i] = rnd.Next(1, 11);
        }

        Console.WriteLine("Numeros generados:");
        for (int i = 0; i < 20; i++)
            Console.Write(numeros[i] + " ");
        Console.WriteLine();

        int[] frecuencia = new int[11]; 
        for (int i = 0; i < 20; i++)
            frecuencia[numeros[i]]++;

        int maxFreq = 0;
        int minFreq = 20;
        int masFrecuente = 0;
        int menosFrecuente = 0;

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("Numero " + i + " aparece " + frecuencia[i] + " veces");

            if (frecuencia[i] > maxFreq)
            {
                maxFreq = frecuencia[i];
                masFrecuente = i;
            }

            if (frecuencia[i] < minFreq)
            {
                minFreq = frecuencia[i];
                menosFrecuente = i;
            }
        }

        Console.WriteLine("Numero mas frecuente: " + masFrecuente);
        Console.WriteLine("Numero menos frecuente: " + menosFrecuente);
    }
}

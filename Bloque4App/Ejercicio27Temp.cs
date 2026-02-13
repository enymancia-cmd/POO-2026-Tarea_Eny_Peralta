using System;

class Ejercicio27
{
    public static void Ejecutar()
    {
        int[] temp = new int[7];

        for (int i = 0; i < 7; i++)
        {
            Console.Write("Temperatura del dia " + (i + 1) + ": ");
            temp[i] = int.Parse(Console.ReadLine());
        }

        int suma = 0;
        int max = temp[0];
        int min = temp[0];

        for (int i = 0; i < 7; i++)
        {
            suma += temp[i];
            if (temp[i] > max) max = temp[i];
            if (temp[i] < min) min = temp[i];
        }

        double promedio = (double)suma / 7;
        Console.WriteLine("Promedio semanal: " + promedio);

        Console.WriteLine("Dias sobre el promedio:");
        for (int i = 0; i < 7; i++)
        {
            if (temp[i] > promedio)
                Console.WriteLine("Dia " + (i + 1) + ": " + temp[i]);
        }

        Console.WriteLine("Dia mas caluroso: " + (Array.IndexOf(temp, max) + 1) + " con " + max);
        Console.WriteLine("Dia mas frio: " + (Array.IndexOf(temp, min) + 1) + " con " + min);

        Console.WriteLine("Variacion entre dias consecutivos:");
        for (int i = 0; i < 6; i++)
            Console.WriteLine("Dia " + (i+1) + " a Dia " + (i+2) + ": " + Math.Abs(temp[i+1] - temp[i]));
    }
}

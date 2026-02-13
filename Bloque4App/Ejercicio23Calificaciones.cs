using System;

class Ejercicio23Calificaciones
{
    public static void Ejecutar()
    {
        Console.Write("Cuantas calificaciones va a ingresar? ");
        int n = int.Parse(Console.ReadLine());

        int[] calificaciones = new int[n];
        int suma = 0;
        int aprobados = 0;
        int max = 0;
        int min = 100;

        for (int i = 0; i < n; i++)
        {
            Console.Write("Ingrese calificacion #" + (i + 1) + ": ");
            calificaciones[i] = int.Parse(Console.ReadLine());

            suma += calificaciones[i];

            if (calificaciones[i] >= 60) aprobados++;
            if (calificaciones[i] > max) max = calificaciones[i];
            if (calificaciones[i] < min) min = calificaciones[i];
        }

        double promedio = (double)suma / n;
        Console.WriteLine("Promedio: " + promedio);
        Console.WriteLine("Maxima: " + max);
        Console.WriteLine("Minima: " + min);
        Console.WriteLine("Cantidad aprobados: " + aprobados);
        Console.WriteLine("Cantidad reprobados: " + (n - aprobados));
    }
}

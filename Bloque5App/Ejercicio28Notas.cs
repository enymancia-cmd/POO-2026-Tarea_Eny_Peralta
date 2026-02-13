using System;

class Ejercicio28Notas
{
    public static void Ejecutar()
    {
        Console.Write("Ingrese la cantidad de estudiantes: ");
        int n = int.Parse(Console.ReadLine());
        int[,] notas = new int[n, 3]; // 3 parciales

        // Ingreso de notas
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Estudiante #" + (i+1));
            for (int j = 0; j < 3; j++)
            {
                Console.Write("Parcial " + (j+1) + ": ");
                notas[i,j] = int.Parse(Console.ReadLine());
            }
        }

        // Promedio por estudiante
        for (int i = 0; i < n; i++)
        {
            int suma = 0;
            for (int j = 0; j < 3; j++)
                suma += notas[i,j];

            Console.WriteLine("Promedio estudiante #" + (i+1) + ": " + (suma / 3));
        }

        // Promedio por parcial
        for (int j = 0; j < 3; j++)
        {
            int suma = 0;
            for (int i = 0; i < n; i++)
                suma += notas[i,j];

            Console.WriteLine("Promedio parcial " + (j+1) + ": " + (suma / n));
        }

        // Mejor promedio estudiante
        int mejorProm = 0;
        int estudianteMejor = 0;
        for (int i = 0; i < n; i++)
        {
            int suma = 0;
            for (int j = 0; j < 3; j++)
                suma += notas[i,j];

            if (suma > mejorProm)
            {
                mejorProm = suma;
                estudianteMejor = i+1;
            }
        }
        Console.WriteLine("Mejor promedio: estudiante #" + estudianteMejor + " con " + (mejorProm / 3));

        // Parcial más dificil
        int parcialDificil = 0;
        int promedioMenor = 101;
        for (int j = 0; j < 3; j++)
        {
            int suma = 0;
            for (int i = 0; i < n; i++)
                suma += notas[i,j];

            int prom = suma / n;
            if (prom < promedioMenor)
            {
                promedioMenor = prom;
                parcialDificil = j+1;
            }
        }
        Console.WriteLine("Parcial mas dificil: " + parcialDificil + " con promedio " + promedioMenor);
    }
}

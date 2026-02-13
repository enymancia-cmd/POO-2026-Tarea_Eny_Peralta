class Ejercicio5Tiempo
{
    public static void Ejecutar()
    {
        Console.WriteLine("Ingrese la hora inicial");

        Console.WriteLine("Hora: ");
        int h1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Minuto: ");
        int m1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Segundo: ");
        int s1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese la hora final");

        Console.WriteLine("Hora: ");
        int h2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Minuto: ");
        int m2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Segundo: ");
        int s2 = int.Parse(Console.ReadLine());

        int tiempo1 = h1 * 3600 + m1 * 60 + s1;
        int tiempo2 = h2 * 3600 + m2 * 60 + s2;

        int diferencia = tiempo2 - tiempo1;

        int horas = diferencia / 3600;
        int minutos = (diferencia % 3600) / 60;
        int segundos = diferencia % 60;

        Console.WriteLine("Tiempo transcurrido:");
        Console.WriteLine(horas + " horas");
        Console.WriteLine(minutos + " minutos");
        Console.WriteLine(segundos + " segundos");
    }
}

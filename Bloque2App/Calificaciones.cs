class Ejercicio10Calificaciones
{
    public static void Ejecutar()
    {
        Console.WriteLine("SISTEMA DE CALIFICACIONES UNAH");

        Console.WriteLine("Ingrese nota (0-100): ");
        int nota = int.Parse(Console.ReadLine());

        if (nota < 0 || nota > 100)
        {
            Console.WriteLine("Nota inválida");
        }
        else if (nota >= 90)
        {
            Console.WriteLine("A");
            Console.WriteLine("Excelente");
            Console.WriteLine("Estado: Aprobado");
        }
        else if (nota >= 80)
        {
            Console.WriteLine("B");
            Console.WriteLine("Muy Bueno");
            Console.WriteLine("Estado: Aprobado");
        }
        else if (nota >= 70)
        {
            Console.WriteLine("C");
            Console.WriteLine("Bueno");
            Console.WriteLine("Estado: Aprobado");
        }
        else if (nota >= 60)
        {
            Console.WriteLine("D");
            Console.WriteLine("Regular");
            Console.WriteLine("Estado: Aprobado");
        }
        else
        {
            Console.WriteLine("F");
            Console.WriteLine("Reprobado");
            Console.WriteLine("Estado: Reprobado");
        }
    }
}

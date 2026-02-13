/* 1 KB = 1024 Bytes
1 MB = 1024 KB
1 GB = 1024 MB
1 TB = 1024 GB
*/
class Ejercicio7Unidades
{
    public static void Ejecutar()
    {
        Console.WriteLine("CONVERSION DE ALMACENAMIENTO");

        Console.WriteLine("1. Bytes a KB");
        Console.WriteLine("2. KB a MB");
        Console.WriteLine("3. MB a GB");
        Console.WriteLine("4. GB a TB");
        Console.WriteLine("5. KB a Bytes");
        Console.WriteLine("6. MB a KB");
        Console.WriteLine("7. GB a MB");
        Console.WriteLine("8. TB a GB");

        Console.WriteLine("Seleccione una opcion: ");
        int opcion = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese cantidad: ");
        double cantidad = double.Parse(Console.ReadLine());

        double resultado = 0;

        if (opcion == 1)
            resultado = cantidad / 1024;

        else if (opcion == 2)
            resultado = cantidad / 1024;

        else if (opcion == 3)
            resultado = cantidad / 1024;

        else if (opcion == 4)
            resultado = cantidad / 1024;

        else if (opcion == 5)
            resultado = cantidad * 1024;

        else if (opcion == 6)
            resultado = cantidad * 1024;

        else if (opcion == 7)
            resultado = cantidad * 1024;

        else if (opcion == 8)
            resultado = cantidad * 1024;

        Console.WriteLine("Resultado: " + resultado);
    }
}

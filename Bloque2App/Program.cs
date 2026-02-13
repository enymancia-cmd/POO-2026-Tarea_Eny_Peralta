using System;

class Program
{
    public static void Main()
    {
        int opcion = 0;

        do
        {
            Console.WriteLine("--- MENU PRINCIPAL BLOQUE 2 ---");
            Console.WriteLine("1. Clasificación de Triángulos");
            Console.WriteLine("2. Sistema de Calificaciones UNAH");
            Console.WriteLine("3. Calculadora de Descuentos");
            Console.WriteLine("4. Año Bisiesto y Días del Mes");
            Console.WriteLine("5. Validador de Fecha");
            Console.WriteLine("6. Cajero Automático");
            Console.WriteLine("7. Salir");

            Console.WriteLine("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());


            if (opcion == 1)
                Ejercicio9Triangulo.Ejecutar();
            else if (opcion == 2)
                Ejercicio10Calificaciones.Ejecutar();
            else if (opcion == 3)
                Ejercicio11Descuentos.Ejecutar();
            else if (opcion == 4)
                Ejercicio12Bisiesto.Ejecutar();
            else if (opcion == 5)
                Ejercicio13ValidadorFecha.Ejecutar();
            else if (opcion == 6)
                Ejercicio14Cajero.Ejecutar();
            else if (opcion == 7)
                Console.WriteLine("Saliendo del Bloque 2...");
            else
                Console.WriteLine("Opción no válida.");

        } while (opcion != 7);
    }
}

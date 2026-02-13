using System;

class Program
{
    static void Main()
    {
        int opcion = 0;

        do
        {
            Console.WriteLine("----- BLOQUE 1 -----");
            Console.WriteLine("1. IMC");
            Console.WriteLine("2. Temperatura");
            Console.WriteLine("3. Billetes");
            Console.WriteLine("4. Prestamo");
            Console.WriteLine("5. Tiempo");
            Console.WriteLine("6. Area y Perimetro");
            Console.WriteLine("7. Unidades");
            Console.WriteLine("8. Salario");
            Console.WriteLine("9. Salir");

            opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
                Ejercicio1IMC.Ejecutar();
            else if (opcion == 2)
                Ejercicio2Temperatura.Ejecutar();
            else if (opcion == 3)
                Ejercicio3Billetes.Ejecutar();
            else if (opcion == 4)
                Ejercicio4Prestamo.Ejecutar();
            else if (opcion == 5)
                Ejercicio5Tiempo.Ejecutar();
            else if (opcion == 6)
                Ejercicio6AreaPerimetro.Ejecutar();
            else if (opcion == 7)
                Ejercicio7Unidades.Ejecutar();
            else if (opcion == 8)
                Ejercicio8Salario.Ejecutar();

        } while (opcion != 9);
    }
}

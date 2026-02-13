using System;

class Ejercicio2Temperatura
{
    public static void Ejecutar()
    {
        int opcion;
        double temperatura;
        double resultado;

        Console.WriteLine("----- CONVERSION DE TEMPERATURA -----");
        Console.WriteLine("1. Celsius a Fahrenheit");
        Console.WriteLine("2. Fahrenheit a Celsius");
        Console.WriteLine("3. Celsius a Kelvin");
        Console.WriteLine("4. Kelvin a Celsius");

        Console.WriteLine("Seleccione una opcion:");
        opcion = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese la temperatura:");
        temperatura = double.Parse(Console.ReadLine());

        if (opcion == 1)
        {
            resultado = (temperatura * 9 / 5) + 32;
            Console.WriteLine("Celsius a Fahrenheit: " + resultado);
        }
        else if (opcion == 2)
        {
            resultado = (temperatura - 32) * 5 / 9;
            Console.WriteLine("Fahrenheit a Celsius: " + resultado);
        }
        else if (opcion == 3)
        {
            resultado = temperatura + 273.15;
            Console.WriteLine("Celsius a Kelvin: " + resultado);
        }
        else if (opcion == 4)
        {
            resultado = temperatura - 273.15;
            Console.WriteLine("Kelvin a Celsius: " + resultado);
        }
        else
        {
            Console.WriteLine("Opcion no valida");
        }
    }
}

using System;

class Ejercicio15Tabla
{
    public static void Ejecutar()
    {
        Console.Write("Ingrese numero: ");
        int numero = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 12; i++)
        {
            Console.WriteLine(numero + " x " + i + " = " + (numero * i));
        }
    }
}

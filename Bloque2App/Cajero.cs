using System;

class Ejercicio14Cajero
{
 public static void Ejecutar()
    {
        int saldo = 1000;
        int opcion;
        int cantidad;

        Console.WriteLine("=== CAJERO AUTOMATICO ===");
        Console.WriteLine("1. Consultar saldo");
        Console.WriteLine("2. Depositar dinero");
        Console.WriteLine("3. Retirar dinero");

        Console.Write("Seleccione una opcion: ");
        opcion = int.Parse(Console.ReadLine());

        if (opcion == 1)
        {
            Console.WriteLine("Su saldo es: " + saldo);
        }
        else if (opcion == 2)
        {
            Console.Write("Ingrese cantidad a depositar: ");
            cantidad = int.Parse(Console.ReadLine());

            saldo = saldo + cantidad;

            Console.WriteLine("Nuevo saldo: " + saldo);
        }
        else if (opcion == 3)
        {
            Console.Write("Ingrese cantidad a retirar: ");
            cantidad = int.Parse(Console.ReadLine());

            if (cantidad <= saldo)
            {
                saldo = saldo - cantidad;
                Console.WriteLine("Retiro exitoso");
                Console.WriteLine("Nuevo saldo: " + saldo);
            }
            else
            {
                Console.WriteLine("Saldo insuficiente");
            }
        }
        else
        {
            Console.WriteLine("Opcion no valida");
        }

        Console.ReadKey();
    }
}

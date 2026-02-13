using System;

class Ejercicio19Adivinanza
{
    public static void Ejecutar()
    {
        Random rnd = new Random();
        int numero = rnd.Next(1, 101);

        int intentos = 7;
        int intento;

        while (intentos > 0)
        {
            Console.Write("Adivine numero 1-100: ");
            intento = int.Parse(Console.ReadLine());

            if (intento == numero)
            {
                Console.WriteLine("Correcto!");
                return;
            }
            else if (intento < numero)
                Console.WriteLine("Mayor");

            else
                Console.WriteLine("Menor");

            intentos--;
        }

        Console.WriteLine("Perdiste. Numero era: " + numero);
    }
}

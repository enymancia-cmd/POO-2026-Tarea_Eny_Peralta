using System;

class Ejercicio20Password
{
    public static void Ejecutar()
    {
        string pass;
        bool valida;

        do
        {
            valida = true;

            Console.Write("Ingrese contraseña: ");
            pass = Console.ReadLine();

            if (pass.Length < 8)
            {
                Console.WriteLine("Minimo 8 caracteres");
                valida = false;
            }

            bool mayus = false;
            bool minus = false;
            bool numero = false;

            for (int i = 0; i < pass.Length; i++)
            {
                if (char.IsUpper(pass[i])) mayus = true;
                if (char.IsLower(pass[i])) minus = true;
                if (char.IsDigit(pass[i])) numero = true;
            }

            if (!mayus) { Console.WriteLine("Falta mayuscula"); valida = false; }
            if (!minus) { Console.WriteLine("Falta minuscula"); valida = false; }
            if (!numero) { Console.WriteLine("Falta numero"); valida = false; }

        } while (!valida);

        Console.WriteLine("Contraseña valida");
    }
}

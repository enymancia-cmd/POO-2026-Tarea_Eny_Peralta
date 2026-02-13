using System;

partial class Program
{
    static void Main()
    {
        int opcion;

        do
        {
            Console.WriteLine("--- BLOQUE 3 - CICLOS ---");
            Console.WriteLine("15. Tabla de multiplicar");
            Console.WriteLine("16. Numeros primos en rango");
            Console.WriteLine("17. Serie Fibonacci");
            Console.WriteLine("18. Factorial y combinaciones");
            Console.WriteLine("19. Juego de adivinanza");
            Console.WriteLine("20. Validacion de contraseña");
            Console.WriteLine("21. Patron de asteriscos");
            Console.WriteLine("22. Calculadora con menu");
            Console.WriteLine("0. Salir");

            Console.Write("Seleccione opcion: ");
            opcion = int.Parse(Console.ReadLine());

            if (opcion == 15)
                Ejercicio15Tabla.Ejecutar();

            else if (opcion == 16)
                Ejercicio16Primos.Ejecutar();

            else if (opcion == 17)
                Ejercicio17Fibonacci.Ejecutar();

            else if (opcion == 18)
                Ejercicio18Factorial.Ejecutar();

            else if (opcion == 19)
                Ejercicio19Adivinanza.Ejecutar();

            else if (opcion == 20)
                Ejercicio20Password.Ejecutar();

            else if (opcion == 21)
                Ejercicio21Patron.Ejecutar();

            else if (opcion == 22)
                Ejercicio22Calc.Ejecutar();

        } while (opcion != 0);
    }
}

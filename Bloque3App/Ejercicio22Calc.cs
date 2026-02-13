using System;

class Ejercicio22Calc
{
    public static void Ejecutar()
    {
        int opcion = 0;

        do
        {
            Console.WriteLine("\n=== CALCULADORA PRINCIPIANTE ===");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opcion: ");
            opcion = int.Parse(Console.ReadLine());

            if (opcion == 0)
            {
                Console.WriteLine("Saliendo de la calculadora...");
                break;
            }

            Console.Write("Ingrese el primer numero: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo numero: ");
            int num2 = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                int resultado = num1 + num2;
                Console.WriteLine("Resultado: " + resultado);
            }
            else if (opcion == 2)
            {
                int resultado = num1 - num2;
                Console.WriteLine("Resultado: " + resultado);
            }
            else if (opcion == 3)
            {
                int resultado = num1 * num2;
                Console.WriteLine("Resultado: " + resultado);
            }
            else if (opcion == 4)
            {
                if (num2 != 0)
                {
                    int resultado = num1 / num2;
                    Console.WriteLine("Resultado: " + resultado);
                }
                else
                {
                    Console.WriteLine("No se puede dividir entre 0");
                }
            }
            else
            {
                Console.WriteLine("Opcion invalida");
            }

        } while (opcion != 0);
    }
}

using System;

class Ejercicio24Busqueda
{
    public static void Ejecutar()
    {
        int[] numeros = new int[10];
        for (int i = 0; i < 10; i++)
        {
            Console.Write("Ingrese numero #" + (i+1) + ": ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < numeros.Length - 1; i++)
        {
            for (int j = 0; j < numeros.Length - 1 - i; j++)
            {
                if (numeros[j] > numeros[j + 1])
                {
                    int temp = numeros[j];
                    numeros[j] = numeros[j + 1];
                    numeros[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("Elementos en posiciones pares:");
        for (int i = 0; i < numeros.Length; i+=2)
            Console.WriteLine(numeros[i]);

        int mayor = numeros[numeros.Length - 1];
        int segundoMayor = numeros[numeros.Length - 2];
        Console.WriteLine("Segundo mayor: " + segundoMayor);

        Console.Write("Ingrese numero a buscar: ");
        int buscar = int.Parse(Console.ReadLine());
        bool encontrado = false;
        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] == buscar)
            {
                encontrado = true;
                Console.WriteLine("Numero encontrado en la posicion: " + i);
                break;
            }
        }
        if (!encontrado)
            Console.WriteLine("Numero no encontrado");
    }
}

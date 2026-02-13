using System;

class Program
{
    static void Main()
    {
        int opcion;

        do
        {
            Console.WriteLine("===== BLOQUE 5 - ARREGLOS BIDIMENSIONALES =====");
            Console.WriteLine("28. Matriz de notas por parcial");
            Console.WriteLine("29. Juego de Gato (Tic-Tac-Toe)");
            Console.WriteLine("30. Inventario simple");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione opcion: ");
            opcion = int.Parse(Console.ReadLine());

            if (opcion == 28)
                Ejercicio28Notas.Ejecutar();
            else if (opcion == 29)
                Ejercicio29Parcial.Ejecutar();
            else if (opcion == 30)
                Ejercicio30Simple.Ejecutar();

        } while (opcion != 0);
    }
}

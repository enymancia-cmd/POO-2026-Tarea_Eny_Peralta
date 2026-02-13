using System;

class Program
{
    static void Main()
    {
        int opcion;

        do
        {
            Console.WriteLine("\n===== BLOQUE 4 - ARREGLOS UNIDIMENSIONALES =====");
            Console.WriteLine("23. Estadisticas de calificaciones");
            Console.WriteLine("24. Busqueda y ordenamiento");
            Console.WriteLine("25. Rotacion de arreglo");
            Console.WriteLine("26. Frecuencia de elementos");
            Console.WriteLine("27. Arreglo de temperaturas");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione opcion: ");
            opcion = int.Parse(Console.ReadLine());

            if (opcion == 23)
                Ejercicio23Calificaciones.Ejecutar();
            else if (opcion == 24)
                Ejercicio24Busqueda.Ejecutar();
            else if (opcion == 25)
                Ejercicio25Rotacion.Ejecutar();
            else if (opcion == 26)
                Ejercicio26Frecuencia.Ejecutar();
            else if (opcion == 27)
                Ejercicio27Temp.Ejecutar();

        } while (opcion != 0);
    }
}

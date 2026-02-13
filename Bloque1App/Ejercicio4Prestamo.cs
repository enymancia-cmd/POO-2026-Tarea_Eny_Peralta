class Ejercicio4Prestamo
{
    public static void Ejecutar()
    {
        Console.WriteLine("Ingrese el monto del prestamo: ");
        double monto = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese la tasa de interes anual (%): ");
        double tasa = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el plazo en meses: ");
        int meses = int.Parse(Console.ReadLine());

        double interes = monto * (tasa / 100) * (meses / 12.0);

        double total = monto + interes;

        double cuota = total / meses;

        Console.WriteLine("Interes total: " + interes);
        Console.WriteLine("Total a pagar: " + total);
        Console.WriteLine("Cuota mensual: " + cuota);
    }
}

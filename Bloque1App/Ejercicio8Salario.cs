class Ejercicio8Salario
{
    public static void Ejecutar()
    {
        Console.WriteLine("CALCULO DE SALARIO SEMANAL");

        Console.WriteLine("Ingrese horas trabajadas: ");
        double horas = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese pago por hora: ");
        double tarifa = double.Parse(Console.ReadLine());

        double salarioNormal = 0;
        double salarioExtra = 0;
        double total = 0;

        if (horas <= 44)
        {
            salarioNormal = horas * tarifa;
        }
        else
        {
            double horasExtra = horas - 44;

            salarioNormal = 44 * tarifa;
            salarioExtra = horasExtra * (tarifa * 1.5);
        }

        total = salarioNormal + salarioExtra;

        Console.WriteLine("Pago normal: " + salarioNormal);
        Console.WriteLine("Pago horas extra: " + salarioExtra);
        Console.WriteLine("Total a pagar: " + total);
    }
}

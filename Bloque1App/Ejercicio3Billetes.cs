class Ejercicio3Billetes
{
    public static void Ejecutar()
    {
        Console.WriteLine("Ingrese el monto en lempiras: ");
        int monto = int.Parse(Console.ReadLine());

        int bill500 = monto / 500;
        monto = monto % 500;

        int bill200 = monto / 200;
        monto = monto % 200;

        int bill100 = monto / 100;
        monto = monto % 100;

        int bill50 = monto / 50;
        monto = monto % 50;

        int bill20 = monto / 20;
        monto = monto % 20;

        int bill10 = monto / 10;
        monto = monto % 10;

        int bill5 = monto / 5;
        monto = monto % 5;

        int bill2 = monto / 2;
        monto = monto % 2;

        int bill1 = monto;

        Console.WriteLine("Desglose de billetes:");

        Console.WriteLine("500: " + bill500);
        Console.WriteLine("200: " + bill200);
        Console.WriteLine("100: " + bill100);
        Console.WriteLine("50: " + bill50);
        Console.WriteLine("20: " + bill20);
        Console.WriteLine("10: " + bill10);
        Console.WriteLine("5: " + bill5);
        Console.WriteLine("2: " + bill2);
        Console.WriteLine("1: " + bill1);
    }
}

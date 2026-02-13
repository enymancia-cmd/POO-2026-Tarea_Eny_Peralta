class Ejercicio11Descuentos
{
    public static void Ejecutar()
    {
        Console.WriteLine("CALCULADORA DE DESCUENTOS");

        Console.WriteLine("Ingrese el monto de compra: ");
        double monto = double.Parse(Console.ReadLine());

        double descuento = 0;

        if (monto >= 2500)
            descuento = monto * 0.15;
        else if (monto >= 1000)
            descuento = monto * 0.10;
        else if (monto >= 500)
            descuento = monto * 0.05;
        else
            descuento = 0;

        double precioFinal = monto - descuento;

        Console.WriteLine("Precio original: L " + monto);
        Console.WriteLine("Descuento: L " + descuento);
        Console.WriteLine("Precio final: L " + precioFinal);
    }
}

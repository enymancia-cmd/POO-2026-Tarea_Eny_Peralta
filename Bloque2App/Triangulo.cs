class Ejercicio9Triangulo
{
    public static void Ejecutar()
    {
        Console.WriteLine("CLASIFICACION DE TRIANGULOS");

        Console.WriteLine("Ingrese lado A: ");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese lado B: ");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese lado C: ");
        double c = double.Parse(Console.ReadLine());

        if (a + b > c && a + c > b && b + c > a)
        {
            if (a == b && b == c)
                Console.WriteLine("Triángulo equilátero");
            else if (a == b || a == c || b == c)
                Console.WriteLine("Triángulo isósceles");
            else
                Console.WriteLine("Triángulo escaleno");

            double a2 = a * a;
            double b2 = b * b;
            double c2 = c * c;

            if (c >= a && c >= b)
            {
                if (a2 + b2 == c2)
                    Console.WriteLine("Triángulo rectángulo");
                else if (a2 + b2 > c2)
                    Console.WriteLine("Triángulo acutángulo");
                else
                    Console.WriteLine("Triángulo obtusángulo");
            }
            else if (b >= a && b >= c)
            {
                if (a2 + c2 == b2)
                    Console.WriteLine("Triángulo rectángulo");
                else if (a2 + c2 > b2)
                    Console.WriteLine("Triángulo acutángulo");
                else
                    Console.WriteLine("Triángulo obtusángulo");
            }
            else 
            {
                if (b2 + c2 == a2)
                    Console.WriteLine("Triángulo rectángulo");
                else if (b2 + c2 > a2)
                    Console.WriteLine("Triángulo acutángulo");
                else
                    Console.WriteLine("Triángulo obtusángulo");
            }
        }
        else
        {
            Console.WriteLine("Los lados ingresados NO forman un triángulo válido");
        }
    }
}

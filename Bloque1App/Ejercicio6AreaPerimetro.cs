class Ejercicio6AreaPerimetro
{
    public static void Ejecutar()
    {
        int opcion;

        Console.WriteLine("MENU FIGURAS");
        Console.WriteLine("1. Circulo");
        Console.WriteLine("2. Triangulo");
        Console.WriteLine("3. Rectangulo");
        Console.WriteLine("4. Trapecio");

        Console.WriteLine("Seleccione opcion: ");
        opcion = int.Parse(Console.ReadLine());

        if (opcion == 1)
        {
            Console.WriteLine("Ingrese radio: ");
            double radio = double.Parse(Console.ReadLine());

            if (radio > 0)
            {
                double area = Math.PI * radio * radio;
                double perimetro = 2 * Math.PI * radio;

                Console.WriteLine("Area: " + area);
                Console.WriteLine("Perimetro: " + perimetro);
            }
            else
            {
                Console.WriteLine("Valores invalidos");
            }
        }

        else if (opcion == 2)
        {
            Console.WriteLine("Ingrese la Base: ");
            double baseT = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la Altura: ");
            double alturaT = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese Lado 1: ");
            double l1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese Lado 2: ");
            double l2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese Lado 3: ");
            double l3 = double.Parse(Console.ReadLine());

            if (baseT > 0 && alturaT > 0 && l1 > 0 && l2 > 0 && l3 > 0)
            {
                double area = (baseT * alturaT) / 2;
                double perimetro = l1 + l2 + l3;

                Console.WriteLine("Area: " + area);
                Console.WriteLine("Perimetro: " + perimetro);
            }
            else
            {
                Console.WriteLine("Valores invalidos");
            }
        }

        else if (opcion == 3)
        {
            Console.WriteLine("Ingrese la Base: ");
            double baseR = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la Altura: ");
            double alturaR = double.Parse(Console.ReadLine());

            if (baseR > 0 && alturaR > 0)
            {
                double area = baseR * alturaR;
                double perimetro = 2 * (baseR + alturaR);

                Console.WriteLine("Area: " + area);
                Console.WriteLine("Perimetro: " + perimetro);
            }
            else
            {
                Console.WriteLine("Valores invalidos");
            }
        }

        else if (opcion == 4)
        {
            Console.WriteLine("Ingrese la Base mayor: ");
            double B = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la Base menor: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese ka Altura: ");
            double h = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese Lado 1: ");
            double l1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese Lado 2: ");
            double l2 = double.Parse(Console.ReadLine());

            if (B > 0 && b > 0 && h > 0 && l1 > 0 && l2 > 0)
            {
                double area = ((B + b) * h) / 2;
                double perimetro = B + b + l1 + l2;

                Console.WriteLine("Area: " + area);
                Console.WriteLine("Perimetro: " + perimetro);
            }
            else
            {
                Console.WriteLine("Valores invalidos");
            }
        }

        else
        {
            Console.WriteLine("Opcion no valida");
        }
    }
}

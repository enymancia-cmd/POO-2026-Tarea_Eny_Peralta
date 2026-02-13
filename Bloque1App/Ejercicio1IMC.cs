using System;

class Ejercicio1IMC
{
    public static void Ejecutar()
    {
        double peso = 0;
        double altura;
        double imc;
    try
        {
        Console.WriteLine("Ingrese su peso en kg:");
        peso = double.Parse(Console.ReadLine());
        }
    catch
        {
            Console.WriteLine("Error de formato en el texto ingresado"); 
        }

        /*try
        {
        Console.WriteLine("Ingrese el primer numero");
        n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo numero");
        n2 = int.Parse(Console.ReadLine());
        }
        catch 
        {
        Console.WriteLine("Error de formato en el texto ingresado"); 
        } */
        Console.WriteLine("Ingrese su altura en metros:");
        altura = double.Parse(Console.ReadLine());
        imc = peso / (altura * altura);

        Console.WriteLine("Su IMC es: " + imc);

        if (imc < 18.5)
        {
            Console.WriteLine("Bajo peso");
        }
        else if (imc < 25)
        {
            Console.WriteLine("Normal");
        }
        else if (imc < 30)
        {
            Console.WriteLine("Sobrepeso");
        }
        else
        {
            Console.WriteLine("Obesidad");
        }
    }
}

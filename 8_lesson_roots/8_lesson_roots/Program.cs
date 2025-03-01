using System;

class Program8
{
    static void Main()
    {
        Console.WriteLine("Корни квадратного уравнения.");
        Console.WriteLine("Введите число a: ");
        double a = Convert.ToDouble(Console.ReadLine().Replace('.', ','));

        Console.WriteLine("Введите число b: ");
        double b = Convert.ToDouble(Console.ReadLine().Replace('.', ','));

        double b2 = Math.Pow(b, 2);

        Console.WriteLine("Введите число c: ");
        double c = Convert.ToDouble(Console.ReadLine().Replace('.', ','));

        double Discriminant = b2 - 4 * a * c;
        double D = Math.Sqrt(Discriminant);

        if (Discriminant > 0)
        {
            double x1 = ((b * (-1)) + D) / (2 * a);
            double x2 = ((b * (-1)) - D) / (2 * a);
            Console.WriteLine($"Корень x1 = {x1}, Корень x2 = {x2}");
        }
        else if (Discriminant == 0)
        {
            double x = (b * (-1) + D) / (2 * a);
            Console.WriteLine($"Один корень, x = {x}");
        }
        else if (Discriminant < 0)
        {
            Console.WriteLine("Корней нет");
        }
    }
}
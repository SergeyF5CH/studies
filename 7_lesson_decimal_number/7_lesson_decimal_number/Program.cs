using System;


class Program7
{
    static void Main()
    {
        Console.WriteLine("Введите число:");
        string value = Console.ReadLine().Replace('.', ',');
        float x1 = float.Parse(value);
        float x2 = (float)Math.Floor(x1);
        float preresult = x1 - x2;
        preresult *= 10;
        int result = (int)Math.Floor(preresult);
        Console.WriteLine(result);

    }
}
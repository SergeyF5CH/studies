﻿class Program5
{
    static void Main()
    {
        int x1 = 0;
        int y1 = 0;
        int x2 = 0;
        int y2 = 0;

        while (true)
        {
            Console.WriteLine("Введите координату позиции, из какой клетки производиться движение по оси X:");
            x1 = Convert.ToInt32((Console.ReadLine()));
            if (x1 < 1 || x1 > 8)
            {
                Console.WriteLine("Неверно указана координата!");
                continue;
            }

            Console.WriteLine("Введите координату позиции, из какой клетки будет производиться движение по оси Y:");
            y1 = Convert.ToInt32((Console.ReadLine()));
            if (y1 < 1 || y1 > 8)
            {
                Console.WriteLine("Неверно указана координата!");
                continue;
            }

            Console.WriteLine("Введите координату позиции, в какую клетку будет производиться движение по оси X:");
            x2 = Convert.ToInt32((Console.ReadLine()));
            if (x2 < 1 || x2 > 8)
            {
                Console.WriteLine("Неверно указана координата!");
                continue;
            }

            Console.WriteLine("Введите координату позиции, в какую клетку будет производиться движение по оси Y:");
            y2 = Convert.ToInt32((Console.ReadLine()));
            if (y2 < 1 || y2 > 8)
            {
                Console.WriteLine("Неверно указана координата!");
                continue;
            }

            break;

        }

        if ((Math.Abs(x1 - x2) == Math.Abs(y1 - y2)) || (x1 == x2 || y1 == y2))
        {
            Console.WriteLine("Ферзь может совершить перемещение.");
        }
        else
        {
            Console.WriteLine("Ферзь не может совершить перемещение.");
        }
    }

}
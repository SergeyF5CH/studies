class Program2
{
    static void Main(string[] args)
    {
        Console.WriteLine("Пересечение отрезков.");
        Console.WriteLine("Введите координаты для отрезка A1B1:");
        int A1 = Convert.ToInt32(Console.ReadLine());
        int B1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите координаты для отрезка A2B2:");
        int A2 = Convert.ToInt32(Console.ReadLine());
        int B2 = Convert.ToInt32(Console.ReadLine());

        if(A1 > A2)
        {
            int x = A1;
            A1 = A2;
            A2 = x;
        }
        if (B1 > B2)
        {
            int y = B1;
            B1 = B2;
            B2 = y;
        }

        if (A2 > B1)
        {
            Console.WriteLine("пустое множество");
        }
        else if (A2 == B1)
        {
            Console.WriteLine($"Точка {A2}");
        }
        else if (A2 < B1) 
        {
            Console.WriteLine($"Точки {A2}; {B1}");
        }
    }
}
class Program3
{
    static void Main()
    {
        Console.WriteLine("Определение совпадения цвета клеток на шахматном поле");

        

        Console.WriteLine("Введите 1-ю координату по оси Y (в пределах от 1го до 8ми: )");
        int y1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите 1-ю координату по оси X (в пределах от 1го до 8ми,)");
        Console.WriteLine("Где А = 1, B = 2 ... H = 8: ");
        int x1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите 2-ю координату по оси Y (в пределах от 1го до 8ми: )");
        int y2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите 2-ю координату по оси X (в пределах от 1го до 8ми,)");
        Console.WriteLine("Где А = 1, B = 2 ... H = 8: ");
        int x2 = Convert.ToInt32(Console.ReadLine());

        int modificator1 = y1 + x1;
        int modificator2 = y2 + x2;

       

        if((modificator1 % 2 ==0 && modificator2 % 2 == 0) || (modificator1 % 2 != 0 && modificator2 % 2 != 0))
        {
            Console.WriteLine("Клетки одинакового цвета ");
        }
        else
        {
            Console.WriteLine("Клетки разного цвета");
        }

     
    }
}
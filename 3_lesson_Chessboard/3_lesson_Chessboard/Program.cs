class Program3
{
    static void Main()
    {
        Console.WriteLine("Определение совпадения цвета клеток на шахматном поле");

        int[] black = new int[] { 2, 4, 6, 8, 10, 12, 14, 16 };
        //int[] white = new int[] { 3, 5, 7, 9, 11, 13, 15 }; - в данном случае не нужен, т.к. можно найти цвет квадрата зная только расположение кв. противоп. цветов.

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

        string coincidence1 = "";
        string coincidence2 = "";

        if (Array.Exists(black, element => element == modificator1))
        {
            coincidence1 = "черная";
        }
        else
        {
            coincidence1 = "белая";
        }

        if (Array.Exists(black, element => element != modificator2))
        {
            coincidence2 = "белая";
        }
        else
        {
            coincidence2 = "черная";
        }

        if (coincidence1.Equals(coincidence2))
        {
            Console.WriteLine("Обе клетки одинакового цвета");
        }
        else
        {
            Console.WriteLine("Клетки не имеют одинакового цвета");
        }
    }
}
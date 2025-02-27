// See https://aka.ms/new-console-template for more information

//Если смешивать цвета то можно получить другой цвет, допустим 

//красный + желтый = оранжевый

//красный + синий = фиолетовый

//синий + желтый = зеленый

//Получаем две строки и выдаем ответ какой цвет в результате. Если введен цвет который мы не поддерживаем нужно вывести ответ “мы не поддерживаем {цвет который ввели}”
//цвета которые появляются в результате смешения нельзя подавать на вход

//while (true)
//        {
//            Console.WriteLine("Введите цвет 1: ");
//            value1 = Console.ReadLine().ToLower();
            
//            if (value1 != c1 || value1 != c2 ||value1 != c3)
//            {
//                Console.WriteLine("Мы не поддерживаем: " + value1);
//            }
//            else
//            {
//                continue;
                
//            }

//            Console.WriteLine("Введите цвет 2: ");
//            value2 = Console.ReadLine().ToLower();

//            if (value2 != c1 || value2 != c2 || value2 != c3)
//            {
//                Console.WriteLine("Мы не поддерживаем: " + value2);
//            }
//            else
//            {
//                continue;
//            }

//            if (!value1.Equals(value2))
//            {
                
//            }
        


class Program
{
    static void Main()
    {
        string value1 = "";
        string value2 = "";

        string c1 = "красный";
        string c2 = "желтый";
        string c3 = "синий";

        Console.WriteLine("Смешение цветов.");

        var Results = new Dictionary<(string, string), string>
        {
            { ("красный", "желтый"), "оранжевый" },
            { ("желтый", "красный"), "оранжевый" },
            { ("красный", "синий"), "фиолетовый" },
            { ("синий", "красный"), "фиолетовый" },
            { ("синий", "желтый"), "зелегый" },
            { ("желтый", "синий"), "зелегый" },
            { ("красный", "красный"), "красный" },
            { ("желтый", "желтый"), "желтый" },
            { ("синий", "синий"), "синий" }
        };


        while ((!value1.Equals(c1) && !value1.Equals(c2) && !value1.Equals(c3)) || (!value2.Equals(c1) && !value2.Equals(c2) && !value2.Equals(c3)))
        {
            Console.WriteLine("Введите значение 1: ");
            value1 = Console.ReadLine().ToLower();
            if (!value1.Equals(c1) && !value1.Equals(c2) && !value1.Equals(c3))
            {
                Console.WriteLine("Мы не поддерживаем: " + value1);
                continue;
            }
           
            Console.WriteLine("Введите значение 2: ");
            value2 = Console.ReadLine().ToLower(); ;
            if (!value2.Equals(c1) && !value2.Equals(c2) && !value2.Equals(c3))
            {
                Console.WriteLine("Мы не поддерживаем: " + value2);
                continue;
            }
            

        }

        var key = (value1, value2);
        if(Results.TryGetValue(key, out string finish))
        {
            Console.WriteLine(finish);
        }
           

    }
}

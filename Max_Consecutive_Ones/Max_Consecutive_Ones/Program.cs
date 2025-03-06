using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите кол-во ячеек массива: ");
        int x = Convert.ToInt32(Console.ReadLine());
        int[] MyArray = new int[x];
        

        for(int i = 0; i < x; i++)
        {
            Console.WriteLine("Введите значение ячейки массива 0 или 1: ");
            MyArray[i] = Convert.ToInt32(Console.ReadLine());
        }

        int maxValue = 0;
        int currentValue = 0;

        Console.WriteLine("");
        
        foreach(int i in MyArray)
        {
            Console.Write($"{i}, ");

            if(i == 1)
            {
                currentValue++;
                if(currentValue > maxValue)
                {
                    maxValue = currentValue;
                }
                
            }
            else
            {
                currentValue = 0;
            }

        }

        Console.WriteLine($"\n \nМаксимальная комбинация едениц {maxValue}");
    }
}
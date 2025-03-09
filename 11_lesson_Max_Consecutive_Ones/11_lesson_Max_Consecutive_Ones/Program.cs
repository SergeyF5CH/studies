using System;


class Program
{
    static void Main()
    {
        Console.WriteLine("Введите кол-во элементов массива: ");
        int x = Convert.ToInt32(Console.ReadLine());
        int[] MyArray = new int[x];

        for(int i = 0; i < x; i++)
        {
            Console.WriteLine($"Введите значение {i+1} элемента массива: ");
            MyArray[i] = Convert.ToInt32(Console.ReadLine());
            MyArray[i] = Convert.ToInt32(Math.Pow(MyArray[i], 2));
            
        }

        for (int i = 0; i < MyArray.Length; i++)
        {
            for(int j = 0; j < MyArray.Length; j++)
            {
                
                if (MyArray[i] < MyArray[j])
                {
                    int temp = MyArray[j];
                    MyArray[j] = MyArray[i];
                    MyArray[i] = temp;                     
                }
                                
            }
            
        }

        Console.Write("\n" + "Вывод квадратов чисел после сортировки: \n");

        foreach (int x1 in MyArray)
        {
            Console.Write($"{x1} ");
        }

        
    }



}
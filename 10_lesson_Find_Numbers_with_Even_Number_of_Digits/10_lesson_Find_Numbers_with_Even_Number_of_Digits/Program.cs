using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите кол-во ячеек массива: ");
        int x = Convert.ToInt32(Console.ReadLine());
        string[] MyArray = new string[x];


        for (int i = 0; i < x; i++)
        {
            Console.WriteLine("Введите значение ячейки массива: ");
            MyArray[i] = Console.ReadLine();
        }

        
        Console.WriteLine("");

        int even_Num = 0;
        int z = 0;
        foreach (string i in MyArray)
        {
            if (MyArray[z].Length % 2 == 0) 
            {
                even_Num++;
               
            }
            z++;

        }
        
        Console.Write(even_Num);


    }
}



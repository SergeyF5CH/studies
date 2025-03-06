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

        List<string> even_Num = new List<string>();
        int z = 0;
        foreach (string i in MyArray)
        {
            if (MyArray[z].Length % 2 == 0) 
            {
                even_Num.Add(MyArray[z]);
               
            }
            z++;

        }
        
        Console.Write(even_Num.Count);


    }
}



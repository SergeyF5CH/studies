using System;

class Program
{
    static void Main()
    {
        Console.WriteLine($"Введите длину массива: ");
        int x = Convert.ToInt32(Console.ReadLine());
        int[] nums = new int[x];
        for (int i = 0; i < nums.Length; i++)
        {
            Console.WriteLine($"Введите число под индексом {i}");
            nums[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Введите число которое хотите удалить из массива: ");
        int val = Convert.ToInt32(Console.ReadLine());

        int k = 0;
        foreach (int i in nums)
        {
            if (i != val)
            {
                nums[k] = i;
                k++;
            }
        }
        Console.WriteLine($"Кол-во элементов не равных val: {k}");
        for (int i = 0; i < k - 1; i++) 
        {
            Console.WriteLine(nums[i]);
        }
    }
}
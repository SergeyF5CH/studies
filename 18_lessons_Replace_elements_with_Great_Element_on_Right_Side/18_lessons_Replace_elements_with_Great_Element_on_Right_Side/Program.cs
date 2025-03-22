using System;

class Program
{
    static void Main()
    {
        int x = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[x];

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine(" ");

        ReplaceElements(arr);

        foreach (int i in arr)
        {
            Console.WriteLine(i + " ");
        }


    }

    static int[] ReplaceElements(int[] arr)
    {
        int MaxR = -1;
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            int current_val = arr[i];
            arr[i] = MaxR;
            MaxR = Math.Max(current_val, MaxR);

        }
        return arr;
    }
}
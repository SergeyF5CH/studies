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

        ReplaceElementsZero(arr);

        foreach (int i in arr)
        {
            Console.WriteLine(i + " ");
        }


    }

    static int[] ReplaceElementsZero(int[] arr)
    {
        for (int i = 0; i <= arr.Length; i++)
        {
            for (int j = i; j <= arr.Length - 1; j++)
            {
                if (arr[i] == 0)
                {
                    int tmp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = tmp;
                    

                }
            }
        }
        return arr;
    }
}
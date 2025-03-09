using System;

class Program
{
    static void Main()
    {
        int[] arr = new int[8] { 1, 0, 2, 3, 0, 4, 5, 0 };
        int _zeroCount = 0;
        for(int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == 0)
            {
                _zeroCount++;

            }

        }

        for (int i = arr.Length - 1, j = arr.Length + _zeroCount - 1; i >= 0; i--)
        {
            if (j < arr.Length)
            {
                arr[j] = arr[i];
            }
            j--;
            
            if (arr[i] == 0)
            {
                if (j < arr.Length)
                {
                    arr[j] = 0;
                }
                j--;
            }

        }


        foreach (int x in arr)
        {
            Console.Write($"{x} ");
        }
    }
}
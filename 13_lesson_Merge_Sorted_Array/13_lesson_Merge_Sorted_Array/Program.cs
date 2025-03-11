using System;

class Program
{
    static void Main()
    {
        int[] first_arr = new int[6] { 1, 2, 3, 0, 0, 0 };
        int[] second_arr = new int[3] { 2, 5, 3 };

        for(int i = 0 ;i < second_arr.Length; i++)
        {
            first_arr[first_arr.Length - 1 - i] = second_arr[second_arr.Length - 1 -i];
        }


        for (int i = 0; i < first_arr.Length; i++)
        {
            for (int j = i + 1; j < first_arr.Length; j++)
            {
                if (first_arr[i] > first_arr[j])
                {
                    int tmp = first_arr[i];
                    first_arr[i] = first_arr[j];
                    first_arr[j] = tmp;
                }


            }


        }

        foreach (int i in first_arr)
        {
            Console.WriteLine(i);
        }
    }
}


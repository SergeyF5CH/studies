using System;

class Program
{
    static void Main()
    {
        int val = Convert.ToInt32(Console.ReadLine());
        int[] heights = new int[val];

        for(int i = 0; i < heights.Length; i++)
        {
            heights[i] = Convert.ToInt32(Console.ReadLine());
        }
        int y = HeightChecker(heights);

        Console.WriteLine($"\nКол-во выставленное не по порядку: {y}");

    }

    static int HeightChecker(int[] heights)
    {
        int[] expected = new int[heights.Length];
        for (int i = 0; i < heights.Length; i++)
        {
            expected[i] = heights[i];
        }

        for (int i = 0; i < heights.Length; i++)
        {
            for (int j = i; j < heights.Length; j++)
            {
                if (expected[i] > expected[j])
                {
                    int tmp = expected[i];
                    expected[i] = expected[j];
                    expected[j] = tmp;
                }

            }
        }


        int x = 0;
        for (int i = 0; i < heights.Length; i++)
        {
            if (heights[i] != expected[i])
            {
                x++;
            }
        }
        return x;
    }
}
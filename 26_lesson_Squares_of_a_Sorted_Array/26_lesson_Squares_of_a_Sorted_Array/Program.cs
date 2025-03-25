using System;

class Program
{
    static void Main()
    {
        int[] nums = new int[] { -4, -1, 0, 3, 10 };

        int[] result = SortedSquares(nums);

        foreach(int i in result)
        {
            Console.Write($"{i}, ");
        }
    }

    static int[] SortedSquares(int[] nums)
    {
        int n = nums.Length;
        int[] arrResult = new int[n];
        int first = 0;
        int second = n - 1;

        for(int i = n - 1; i >= 0; i--)
        {
            if(Math.Abs(nums[first]) > Math.Abs(nums[second]))
            {
                arrResult[i] = nums[first] * nums[first];
                first++;
            }
            else
            {
                arrResult[i] = nums[second] * nums[second];
                second--;
            }
        }
        return arrResult;
    }


}
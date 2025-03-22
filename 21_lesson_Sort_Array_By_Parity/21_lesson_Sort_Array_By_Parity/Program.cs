using System;

class Program
{
    static void Main()
    {
        int x = Convert.ToInt32(Console.ReadLine());
        int[] nums = new int[x];

        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine(" ");

        ReplaceElements(nums);

        foreach (int i in nums)
        {
            Console.WriteLine(i + " ");
        }


    }

    static int[] ReplaceElements(int[] nums)
    {
        for (int i = 0; i <= nums.Length; i++)
        {
            for (int j = i; j <= nums.Length - 1; j++)
            {
                if (nums[i] % 2 != 0)
                {
                    int tmp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = tmp;


                }
            }

        }
        return nums;
    }
}
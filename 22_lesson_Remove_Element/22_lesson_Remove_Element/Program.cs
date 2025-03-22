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

        int val = Convert.ToInt32(Console.ReadLine());

        int k = RemoveElement(nums, val);
        Console.WriteLine("\nResult: ");
        for (int i = 0; i < k; i++)
        {
            Console.Write(nums[i] + " ");
        }


    }

    static int RemoveElement(int[] nums, int val)
    {
        int k = 0;
        foreach (int i in nums)
        {
            if (i != val)
            {
                nums[k++] = i;

            }

        }
        return k;



    }
}
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

        int result = ThirdMax(nums);

        Console.WriteLine($"\nТретье отличное максимальное число в этом массиве: {result}");
    }

    static int ThirdMax(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for(int j = i; j < nums.Length; j++)
            {
                if (nums[j] > nums[i])
                {
                    int tmp = nums[j];
                    nums[j] = nums[i];
                    nums[i] = tmp;
                }
            }
        }

        int elemCount = 1;
        int prevElem = nums[0];

        for(int index = 1; index < nums.Length; index++)
        {
            if (nums[index] != prevElem)
            {
                elemCount++;
                prevElem = nums[index];
            }

            if(elemCount == 3)
            {
                return nums[index];
            }
        }


        return nums[0];
    }
}
class Program
{
    static void Main(string[] args)
    {
        int[] nums = [1, 1, 0, 1, 1, 1];
        FindMaxConsecutiveOnes(nums);
    }

    static int FindMaxConsecutiveOnes(int[] nums)
    {
        int max = 0;
        int current = 0;

        foreach (int i in nums)
        {
            if (i == 1)
            {
                current++;
                if (current > max)
                {
                    max = current;
                }
            }
            else
            {
                current = 0;
            }
        }
        Console.WriteLine($"{max}");
        return max;
    }
}
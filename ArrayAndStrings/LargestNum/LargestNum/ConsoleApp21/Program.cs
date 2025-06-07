class Program
{
    static void Main(string[] args)
    {
        int[] nums = [3, 6, 1, 0];
        int largestInteger = DominantIndex(nums);
        Console.WriteLine(largestInteger);
    }
    static int DominantIndex(int[] nums)
    {
        int maxValue = nums[0];
        int maxIndex = 0;

        for (int x = 0; x < nums.Length; x++)
        {
            if (nums[x] > maxValue)
            {
                maxValue = nums[x];
                maxIndex = x;
            }
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (i != maxIndex && nums[i] * 2 > maxValue)
            {
                return -1;
            }
        }

        return maxIndex;

    }
}
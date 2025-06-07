class Program
{
    static void Main()
    {
        int[] nums = [0, 1, 0, 3, 12];

        ReplaceElementsZero(nums);

        Console.WriteLine(String.Join(", ", nums));
    }

    static int[] ReplaceElementsZero(int[] nums)
    {
        for (int i = 0; i <= nums.Length; i++)
        {
            for (int j = i; j <= nums.Length - 1; j++)
            {
                if (nums[i] == 0)
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
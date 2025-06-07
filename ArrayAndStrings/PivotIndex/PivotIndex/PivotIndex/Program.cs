class Program
{
    static void Main(string[] args)
    {
        int[] nums = [2, 1, -1];
        int pivotIndex = PivotIndex(nums);
        Console.WriteLine(pivotIndex);
    }

    static int PivotIndex(int[] nums)
    {
        if (nums.Length == 0)
        {
            return -1;
        }

        int[] sumLeft = new int[nums.Length];
        int[] sumRight = new int[nums.Length];

        sumLeft[0] = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            sumLeft[i] = sumLeft[i - 1] + nums[i - 1];
        }

        sumRight[nums.Length - 1] = 0;
        for (int i = nums.Length - 2; i >= 0; i--)
        {
            sumRight[i] = sumRight[i + 1] + nums[i + 1];
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (sumRight[i] == sumLeft[i])
            {
                return i;
            }
        }
        return -1;
    }
}
class Program
{
    static void Main(string[] args)
    {
        int[] nums = [2, 3, 1, 2, 4, 3];
        int target = 7;

        int minLength = MinSubArrayLen(target, nums);

        Console.WriteLine(minLength);
    }
    static int MinSubArrayLen(int target, int[] nums)
    {
        int minLength = int.MaxValue;
        int left = 0;
        int currSum = 0;

        for (int right = 0; right < nums.Length; right++)
        {
            currSum += nums[right];

            while (currSum >= target)
            {
                minLength = Math.Min(minLength, right - left + 1);
                currSum -= nums[left];
                left++;
            }
        }
        return minLength == int.MaxValue ? 0 : minLength;
    }
}
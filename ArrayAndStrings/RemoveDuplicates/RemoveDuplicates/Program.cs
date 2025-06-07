class Program
{
    static void Main(string[] args)
    {
        int[] nums = [0, 0, 1, 1, 1, 2, 2, 3, 3, 4];
        int k = RemoveDuplicates(nums);
        Console.WriteLine($"Уникальных элементов {k}");
        Console.WriteLine(String.Join(", ", nums));
    }

    static int RemoveDuplicates(int[] nums)
    {
        int k = 1;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[i - 1])
            {
                nums[k] = nums[i];
                k++;
            }
        }

        return k;
    }
}
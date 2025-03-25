using System;

class Program
{
    static void Main()
    {
        int[] nums = new int[] { 4, 3, 2, 7, 8, 2, 3, 1 };

        IList<int> missingNums = FindDisappearedNumbers(nums);

        Console.WriteLine(string.Join(", ", missingNums));


    }

    static IList<int> FindDisappearedNumbers(int[] nums)
    {
        int n = nums.Length;
        HashSet<int> numSet = new HashSet<int>(nums);
        IList<int> result = new List<int>();
        for(int i = 1; i <= n; i++)
        {
            if (!numSet.Contains(i))
            {
                result.Add(i);
            }
        }

        return result;
    }
}
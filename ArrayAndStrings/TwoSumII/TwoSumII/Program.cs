class Program
{
    static void Main(string[] args)
    {
        int[] numbers = [2, 7, 11, 15];
        int target = 9;
        int[] result = TwoSum(numbers, target);
        Console.WriteLine(String.Join(", ", result));
    }
    static int[] TwoSum(int[] numbers, int target)
    {
        int left = 0;
        int right = numbers.Length - 1;

        while(left < right)
        {
            int sum = numbers[left] + numbers[right];

            if(sum == target)
            {
                int[] result = new int[] { left+1, right+1};
                return result;
            }
            else if (sum < target)
            {
                left++;
            }
            else
            {
                right--;
            }
        }
        int[] noResult = new int[] { 0, 0 };
        return noResult;
    }
}

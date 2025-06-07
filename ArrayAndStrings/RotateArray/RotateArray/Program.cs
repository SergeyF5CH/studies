class Program
{
    static void Main(string[] args)
    {
        int[] nums = [1, 2, 3, 4, 5, 6, 7];
        int k = 3;
        Rotate(nums, k);
    }
    static void Rotate(int[] nums, int k)
    {
        k %= nums.Length; 
        int[] temp = new int[nums.Length];

        Array.Copy(nums, nums.Length - k, temp, 0, k);
        Array.Copy(nums, 0, temp, k, nums.Length - k);
        Array.Copy(temp, nums, nums.Length);

        Console.WriteLine(String.Join(", ", nums));
    }
}
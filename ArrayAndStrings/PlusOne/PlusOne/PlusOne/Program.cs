class Program
{
    static void Main(string[] args)
    {
        int[] digits = [1, 2, 3];
        int[] result = PlusOne(digits);
        foreach (int i in result) 
        { 
            Console.Write(i + " ");
        }
    }
    static int[] PlusOne(int[] digits)
    {
        int digitsMax = digits[0];
        int digitsIndex = 0;

        for (int i = 0; i < digits.Length; i++)
        {
            digitsMax = digits[i];
            digitsIndex = i;
        }

        for (int i = 0; i < digits.Length; i++)
        {
            if (digitsMax == digits[i] && digitsIndex == i)
            {
                ++digits[i];
            }
        }

        return digits;
    }
}
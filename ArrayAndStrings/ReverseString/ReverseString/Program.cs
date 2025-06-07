class Program
{
    static void Main(string[] args)
    {
        char[] s = ['h', 'e', 'l', 'l', 'o'];
        ReverseString(s);
        foreach(char chars in s)
        {
            Console.Write(chars + " ");
        }
    }

    static void ReverseString(char[] s)
    {
        int j = s.Length - 1;
        for (int i = 0; i <= j; i++)
        {            
            char temp = s[i];
            s[i] = s[j];
            s[j] = temp;
            j--;
        }

    }
}
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string s = "Let's take LeetCode contest";
        Console.WriteLine(ReverseWords(s));
    }

    static string ReverseWords(string s)
    {
        StringBuilder result = new StringBuilder();
        int wordStart = 0;

        for (int i = 0; i <= s.Length; i++)
        {
            if (i == s.Length || s[i] == ' ')
            {
                for (int j = i - 1; j >= wordStart; j--)
                {
                    result.Append(s[j]);
                }

                if (i != s.Length)
                {
                    result.Append(' ');
                }

                wordStart = i + 1;
            }
        }

        return result.ToString();
    }
}
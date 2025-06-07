class Program
{
    static void Main(string[] args)
    {
        string s = "the sky is blue";
        Console.WriteLine(ReverseWords(s));

    }
    static string ReverseWords(string s)
    {
        string[] words = s.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        Array.Reverse(words);
        return String.Join(" ", words);
    }
}
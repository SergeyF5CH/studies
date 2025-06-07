class Program
{
    static void Main(string[] args)
    {
        string haystack = "sadbutsad";
        string needle = "sad";
        Console.WriteLine(StrStr(haystack, needle));
    }
    static int StrStr(string haystack, string needle)
    {
        for (int i = 0; i <= haystack.Length - needle.Length; i++)
        {
            bool match = true;
            for (int j = 0; j < needle.Length; j++)
            {
                if (haystack[i + j] != needle[j])
                {
                    match = false;
                    break;
                }
            }
            if (match)
            {
                return i;
            }
        }
        return -1;
    }
}
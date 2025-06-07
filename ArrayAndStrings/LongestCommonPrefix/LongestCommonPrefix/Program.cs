class Program
{
    static void Main(string[] args)
    {
        string[] strs = ["flower", "flow", "flight"];
        string result = LongestCommonPrefix(strs);
        Console.WriteLine(result);
    }

    static string LongestCommonPrefix(string[] strs)
    {
        string commonPrefix = strs[0];
        for(int i = 1; i < strs.Length; i++)
        {
            while (strs[i].IndexOf(commonPrefix) != 0)
            {
                commonPrefix = commonPrefix.Substring(0, commonPrefix.Length - 1);
            }
        }
        return commonPrefix;

    }
}
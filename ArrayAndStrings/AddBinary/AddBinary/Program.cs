class Program
{
    static void Main(string[] args)
    {
        string a = "11";
        string b = "1";
        string result = AddBinary(a, b);
        Console.WriteLine(result);
    }
    static string AddBinary(string a, string b)
    {
        int a1 = Convert.ToInt32(a, 2);
        int b1 = Convert.ToInt32(b, 2);
        int result = a1 + b1;
        return Convert.ToString(result, 2);
    }
}
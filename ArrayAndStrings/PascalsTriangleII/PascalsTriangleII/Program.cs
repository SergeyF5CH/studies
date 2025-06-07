class Program
{
    static void Main(string[] args)
    {
        int rowIndex = 3;
        IList<int> rowResult = new List<int>(GetRow(rowIndex));
        Console.WriteLine(string.Join(", ", rowResult));
    }
    static IList<int> GetRow(int rowIndex)
    {
        List<int> row = new List<int>(rowIndex + 1);
        row.Add(1); 

        for (int i = 1; i <= rowIndex; i++)
        {
            long nextVal = (long)row[i - 1] * (rowIndex - i + 1) / i;
            row.Add((int)nextVal);
        }

        return row;
    }
}
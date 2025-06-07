class Program
{
    static void Main(string[] args)
    {
        int[][] mat = [[1, 2, 3], [4, 5, 6], [7, 8, 9]];
        int[] result = FindDiagonalOrder(mat);
        Console.WriteLine(string.Join(", ", result));
    }
    static int[] FindDiagonalOrder(int[][] mat)
    {
        int m = mat.Length;
        int n = mat[0].Length;
        int[] result = new int[n * m];
        int index = 0;

        Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                int sum = i + j;
                if (!dict.ContainsKey(sum))
                {
                    dict[sum] = new List<int>();
                }
                dict[sum].Add(mat[i][j]);
            }
        }

        foreach (int key in dict.Keys)
        {
            if (key % 2 == 0)
            {
                dict[key].Reverse();
            }
            foreach (int num in dict[key])
            {
                result[index++] = num;
            }
        }

        return result;
    }
}
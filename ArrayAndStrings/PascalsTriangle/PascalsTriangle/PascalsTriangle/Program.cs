class Solution
{
    static void Main(string[] args)
    {
        int numRows = Convert.ToInt32(Console.ReadLine());

        IList<IList<int>> pascalTriangle = Generate(numRows);
        foreach(var row in pascalTriangle)
        {
            foreach (var i in row)
            {
                Console.Write(String.Join(", ", i));
            }
            Console.WriteLine() ;
        }

    }
    static IList<IList<int>> Generate(int numRows)
    {
        var triangle = new List<IList<int>>();
        
        if (numRows == 0)
        {
            return triangle;
        }

        triangle.Add(new List<int> {1});

        for (int i = 1; i < numRows; i++)
        {
            var row = new List<int>();
            row.Add(1);

            var preRow = triangle[i - 1];

            for (int j = 1; j < i; j++)
            {
                row.Add(preRow[j - 1] + preRow[j]);
            }
            row.Add(1);
            triangle.Add(row);
        }
        return triangle;     
    }
}
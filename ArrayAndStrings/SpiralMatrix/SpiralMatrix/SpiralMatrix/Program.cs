class Solution
{
    static void Main(string[] args)
    {
        int[][] matrix = 
        [[1, 2, 3], 
        [4, 5, 6], 
        [7, 8, 9]];
        Console.WriteLine(String.Join(", ",SpiralOrder(matrix)));
    }
    static IList<int> SpiralOrder(int[][] matrix)
    {
        List<int> result = new List<int>();
        if (matrix == null || matrix.Length == 0)
        {
            return result;
        }

        int top = 0, bottom = matrix.Length - 1;
        int left = 0, right = matrix[0].Length - 1;

        while (top <= bottom && left <= right)
        {
            for (int i = left; i <= right; i++)
            {
                result.Add(matrix[top][i]);
            }
            top++;

            for (int i = top; i <= bottom; i++)
            {
                result.Add(matrix[i][right]);
            }
            right--;

            if (top <= bottom)
            {
                for (int i = right; i >= left; i--)
                {
                    result.Add(matrix[bottom][i]);
                }
                bottom--;
            }

            if (left <= right)
            {
                for (int i = bottom; i >= top; i--)
                {
                    result.Add(matrix[i][left]);
                }
                left++;
            }
        }
        return result;
    }
}
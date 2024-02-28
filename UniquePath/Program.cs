public class Program
{
    public static void Main(string[] args)
    {
        //Console.WriteLine(UniquePaths(3, 7));

        int[] nums = { 0, 2 };

        Console.WriteLine(MaxProduct(nums));
    }

    public static int UniquePaths(int m, int n)
    {
        int row = 0;
        int col = 0;
        int totalPath = 0;

        totalPath = TraverseGrid(m, n, row, col, totalPath);
        return totalPath;
    }

    public static int TraverseGrid(int m, int n, int row, int col, int totalPath)
    {
        if (row == m - 1 && col == n - 1)
            return 1;
        if (row + 1 < m)
        {
            row++;
            totalPath += TraverseGrid(m, n, row, col, totalPath);
        }
        if (col + 1 < n)
        {
            col++;
            totalPath += TraverseGrid(m, n, row, col, totalPath);
        }

        return totalPath;
    }

    public static int MaxProduct(int[] nums)
    {
        if (!nums.Any())
            return 0;
        else if (nums.Length == 1)
            return nums[0];
        else
        {
            int max = nums[0] * nums[1];

            for (int i = 1; i < nums.Length - 1; i++)
            {
                if (max < nums[i] * nums[i + 1])
                    max = nums[i] * nums[i + 1];
            }
            return max;
        }
        return 0;
    }
}
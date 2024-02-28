public class Program
{
    public static void Main(string[] args)
    {
        int[] nums = { 1, 2, 3, 1 };
        Console.WriteLine(ContainsDuplicate(nums));
    }

    public static bool ContainsDuplicate(int[] nums)
    {
        var memo = new Dictionary<int, int>();
        foreach (int n in nums)
        {
            if (memo.ContainsKey(n))
                return true;
            else if (!memo.ContainsKey(n))
                memo[n] = 1;
            else
                memo[n] += 1;
        }
        return false;
    }
}
public class Solution {
    public int ClimbStairs(int n) {
        int[] memo = new int[n+1];

        for (int i = n; i >= 0; i--) {
            if (i == n)
                memo[i] = 1; // default as 1
            else if (i + 1 == n)
                memo[i] = 1; // when there is 1 step
            else
                memo[i] = memo[i+1] + memo[i+2];
        }

        return memo[0];
    }

    // public int ClimbStairs(int n) {
    //     Dictionary<int, int> memo = new Dictionary<int, int>();
    //     return FindPath(0, n, ref memo);
    // }

    // private int FindPath(int s, int target, ref Dictionary<int, int> memo) {
    //     if (s == target)
    //         return 1;
    //     if (s > target)
    //         return 0;
    //     if (memo.ContainsKey(s))
    //         return memo[s];
        
    //     int countPath = FindPath(s + 1, target, ref memo);
    //     countPath += FindPath(s + 2, target, ref memo);
    //     memo.Add(s, countPath);
    //     return countPath;
    // }
}
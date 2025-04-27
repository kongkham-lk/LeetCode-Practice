public class Solution {
    public int ClimbStairs(int n) {
        Dictionary<int, int> memo = new Dictionary<int, int>();
        return FindPath(0, n, ref memo);
    }

    private int FindPath(int s, int target, ref Dictionary<int, int> memo) {
        if (s == target)
            return 1;
        if (s > target)
            return 0;
        if (memo.ContainsKey(s))
            return memo[s];
        
        int countPath = FindPath(s + 1, target, ref memo);
        countPath += FindPath(s + 2, target, ref memo);
        memo.Add(s, countPath);
        return countPath;
    }
}
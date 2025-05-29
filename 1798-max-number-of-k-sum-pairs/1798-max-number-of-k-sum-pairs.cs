public class Solution {
    public int MaxOperations(int[] nums, int k) {
        List<int> memo = new List<int>();
        int res = 0;

        foreach(int n in nums) {
            int temp = k - n;
            if (memo.Contains(n)) {
                res++;
                memo.Remove(n);
                // Console.WriteLine("rm : " + n);
            } else {
                memo.Add(temp);
                // Console.WriteLine("add: " + temp);
            }
        }
        return res;
    }
}
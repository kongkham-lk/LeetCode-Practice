public class Solution {
    public int MaxOperations(int[] nums, int k) {
        List<int> memo = new List<int>();
        int res = 0;

        foreach(int n in nums) {
            if (memo.Contains(n)) {
                res++;
                memo.Remove(n);
                Console.WriteLine("rm : " + n);
            } else {
                int temp = k - n;
                memo.Add(temp);
                Console.WriteLine("add: " + temp);
            }
        }
        return res;
    }
}
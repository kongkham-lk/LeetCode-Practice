public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> memo = new HashSet<int>();

        foreach(int n in nums) {
            if (memo.Contains(n)) return true;
            memo.Add(n);
        }
        return false;
    }
}
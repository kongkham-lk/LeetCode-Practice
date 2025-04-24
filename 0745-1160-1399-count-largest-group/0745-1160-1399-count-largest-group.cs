public class Solution {
    public int CountLargestGroup(int n) {
        int[] mem = new int[9 * 4 + 1]; // worst case: 9999 -> 9+9+9+9, +1 include 0
        int limit = 9;
        for (int i = 1; i <= n; i++) {
            int r = 0;
            int t = i;
            
            while (t > 0) {
                r += t % 10;
                t /= 10;
            }
            mem[r]++;
        }

        int max = 0;
        int count = 0;
        for (int i = 0; i < mem.Count(); i++)
            max = Math.Max(max, mem[i]);
        for (int i = 0; i < mem.Count(); i++)
            if (mem[i] == max)
                count++;
        
        return count;
    }
}
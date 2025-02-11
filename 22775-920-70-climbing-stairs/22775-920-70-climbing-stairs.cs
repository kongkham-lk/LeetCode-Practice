public class Solution {
    public int ClimbStairs(int n) {
        int count1 = 0, count2 = 0;

        for (int i = n; i >= 0; i--)
        {
            if (i == n)
                count2 = 1;
            else if (i + 1 == n)
                count1 = count2;
            else if (count1 != 0 && count2 != 0) {
                int temp = count2;
                count2 = count1;
                count1 = count2 + temp;
            }
        }

        return count1;
    }
}
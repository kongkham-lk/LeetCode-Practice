public class Solution {
    public int[] CountBits(int n) {
        int[] result = new int[n+1];
        for (int i = 0; i < n + 1; i++) {
            int count = 0;
            int temp = i;
            while (temp > 0) {
                count += temp % 2;
                temp = temp / 2;
            }
            result[i] = count;
        }
        return result;
    }
}
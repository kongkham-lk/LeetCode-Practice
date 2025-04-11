public class Solution {
    public int HammingWeight(int n) {
        int count = 0;
        while (n != 0) { // slowly reduce n by 1 bit, increment count when the current bit is 1
            if ((n & 1) == 1)
                count++;
            n = n >> 1;
        }
        return count;
    }
}
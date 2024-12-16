public class Solution {
    public int GetSum(int a, int b) {
        while (b != 0) { // b as carry, a as result, no need to use 2's compliment here
            int tmp = (a & b) << 1;
            a = a ^ b;
            b = tmp;
        }
        return a;
    }
}
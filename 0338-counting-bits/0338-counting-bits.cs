public class Solution {
    public int[] CountBits(int n) {
        int[] result = new int[n + 1];
        int sigNum = 2;
        int offset = sigNum / 2;
        for (int i = 0; i < sigNum && i < n + 1; i++) { // for n eq 0 and 1
            int count = 0;
            int temp = i;
            while (temp > 0) {
                count += temp % 2;
                temp = temp / 2;
            }
            result[i] = count;
        }
        
        for (int i = sigNum; i < n + 1; i++) { // for n eq 2 and onward
            if (i == sigNum) {
                offset = sigNum;
                sigNum *= 2;
            }
            result[i] = 1 + result[i - offset];
        }
        return result;
    }
}
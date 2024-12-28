public class Solution {
    public int Reverse(int x) {
        if (x == 0)
            return x;
        bool isNeg = x < 0;
        if (isNeg)
            x *= -1;

        int result = 0;
        long temp = result;
        while (x > 0)
        {
            temp *= 10;
            temp += x % 10;
            x = x / 10;
            result = (int)temp;
            if (temp != result)
                return 0;
        }

        if (isNeg) return result * -1;
        return result;
    }
}
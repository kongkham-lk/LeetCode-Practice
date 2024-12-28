public class Solution {
    public int Reverse(int x) {
            int result = 0;
            int temp = 0;
            while (x != 0)
            {
                if (result > Int32.MaxValue / 10) return 0;
                if (result < Int32.MinValue / 10) return 0;
                temp = x % 10;
                result = result * 10 + temp;
                x /= 10;
            }
            return result;
    }
}
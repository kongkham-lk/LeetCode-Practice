public class Solution {
    public int MaximumTastiness(int[] price, int k) {
        Array.Sort(price);

        int l = 0, r = price[price.Length - 1];

        while (l <= r)
        {
            int mid = l + (r - l)/2;
            if (HasMaximumTastiness(price, mid, k)) l = mid + 1;
            else r = mid - 1;
        }

        return l - 1;
    }

    public bool HasMaximumTastiness(int[] price, int mid, int k)
    {
        int l = price[0], i = 1, count = 1;

        while (i < price.Length && count < k)
        {
            if (price[i] - l >= mid)
            {
                count++;
                l = price[i];
            }
            i++;
        }

        return count == k;
    }
}
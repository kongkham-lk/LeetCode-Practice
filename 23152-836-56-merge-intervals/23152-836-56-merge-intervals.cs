public class Solution {
    public int[][] Merge(int[][] intervals) {
            Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
            int k = 0;
            for (int i = 1; i < intervals.Length; i++)
            {
                int[] prev = intervals[k];
                int[] curr = intervals[i];
                if (prev[1] >= curr[0])
                    intervals[k][1] = Math.Max(prev[1], curr[1]);
                else
                {
                    k++;
                    intervals[k] = curr;
                }
            }

            int[][] result = intervals.Where((el, index) => index <= k).ToArray();
            return result;
    }
}
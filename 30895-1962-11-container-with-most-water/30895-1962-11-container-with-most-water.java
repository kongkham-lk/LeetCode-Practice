class Solution {
    public int maxArea(int[] height) {
        int l = 0;
        int r = height.length - 1;
        int maxArea = (r - l) * Math.min(height[l], height[r]); // get initial maxArea of no change made to l and r.
        while (l < r) {
            if (height[l] <= height[r])
                l++;
            else
                r--;
            int w = r - l;
            int h = Math.min(height[l], height[r]);
            int area = w * h;
            maxArea = Math.max(maxArea, area); // get new area after l or r changed
        }
        return maxArea;
    }
}
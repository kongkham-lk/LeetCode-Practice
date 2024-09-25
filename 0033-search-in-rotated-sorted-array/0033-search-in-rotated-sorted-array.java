class Solution {
    public int search(int[] nums, int target) {
        if (nums.length == 0)
            return -1;

        return searchTarget(nums, 0, nums.length - 1, target);
    }
    
    private int searchTarget(int[] nums, int l, int r, int target) {
        if (r - l <= 1)
            if (nums[l] == target)
                return l;
            else if (nums[r] == target)
                return r;
            else
                return -1;
        int foundIndex = -1;
        int mid = (r - l) / 2 + l;
        if (nums[l] == target)
            return l;
        // since the sorted list can randomly start with big number,
        // which if the target number is smaller, 0, and the starteing el is 4,
        // it is better to start from the right half, then go the the left if not found on the right
        else if (target < nums[l]) {
            foundIndex = searchTarget(nums, mid, r, target); // first check from the other side
            if (foundIndex == -1) // cover the other side
                if (nums[mid] > target) // determine which side should go to base on the mid, follow the normal binary search logic
                    foundIndex = searchTarget(nums, l, mid, target);
                else
                    foundIndex = searchTarget(nums, mid, r, target);
        } else if (target > nums[l]) {
            foundIndex = searchTarget(nums, l, mid, target);
            if (foundIndex == -1)
                if (target < nums[mid])
                    foundIndex = searchTarget(nums, l, mid, target);
                else
                    foundIndex = searchTarget(nums, mid, r, target);
        }
        return foundIndex;
    }
}
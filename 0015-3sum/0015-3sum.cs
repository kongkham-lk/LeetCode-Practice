public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        IList<IList<int>> resultList = new List<IList<int>>();

        for (int i = 0; i < nums.Length; i++)
        {
            // skip when encourter repeat element while handle out of bound exception
            if (i > 0 && nums[i] == nums[i-1])
                continue;

            int j = i + 1;
            int k = nums.Length - 1;

            while (j < k)
            {
                int total = nums[i] + nums[j] + nums[k];

                // need to k-- instead of j++ because the array is already sorted, if too big then shift down, if too small then shift up
                if (total > 0)
                    k--;
                else if (total < 0)
                    j++;
                else
                {
                    resultList.Add(new List<int>() {nums[i], nums[j], nums[k]});
                    j++;
                    
                    while (nums[j] == nums[j-1] && j < k) {
                        j++;
                    }
                }
            }
        }
        return resultList;
    }
}
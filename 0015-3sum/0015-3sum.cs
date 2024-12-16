public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        IList<IList<int>> resultList = new List<IList<int>>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (i > 0 && nums[i] == nums[i-1]) // skip duplicate el of i
                continue;

            int j = i + 1;
            int k = nums.Length - 1;
            int valI = nums[i];
            int valIJ = valI + ((j < k) ? nums[j] : 0);

            while (j < k)
            {
                int total = valIJ + nums[k];

                // need to k-- instead of j++ because the array is already sorted, if too big then shift down, if too small then shift up
                if (total > 0)
                    k--;
                else if (total < 0) {
                    j++;
                    if (j < k)
                        valIJ = valI + nums[j];
                }
                else
                {
                    resultList.Add(new List<int>() {nums[i], nums[j], nums[k]});
                    j++;
                    
                    while (nums[j] == nums[j-1] && j < k)  // skip duplicate el of j
                        j++;
                    if (j < k)
                        valIJ = valI + nums[j];
                }
            }
        }
        return resultList;
    }
}
class Solution:
    def sortColors(self, nums: List[int]) -> None:
        temp = [0] * (max(nums) + 1)
        for n in nums:
            temp[n] = temp[n] + 1
        print(temp)
        curr = 0
        for i in range(len(temp)):
            for t in range(temp[i]):
                nums[curr] = i
                curr = curr + 1
            print(i, temp[i], '->', nums)
        """
        Do not return anything, modify nums in-place instead.
        """
        
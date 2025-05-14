class Solution:
    def increasingTriplet(self, nums: List[int]) -> bool:
        first = second = max(nums)
        for n in nums:
            if first >= n:
                first = n
            elif second >= n:
                second = n
            else:
                return True      
        return False
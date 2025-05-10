class Solution:
    def minSum(self, nums1: List[int], nums2: List[int]) -> int:
        zeros = [0,0]
        sums = [0,0]
        def findSumAndZero(nums: List[int], n: int):
            for v in nums:
                if v == 0:
                    zeros[n] += 1
                else:
                    sums[n] += v
        
        findSumAndZero(nums1, 0)
        findSumAndZero(nums2, 1)

        print("sums :", sums[0], ",", sums[1])
        print("zeros:", zeros[0], ",", zeros[1])

        largerSum = 0
        if sums[largerSum] < sums[largerSum+1]:
            largerSum = 1
        smallerSum = (largerSum+1)%2
        sum1 = sums[largerSum] + zeros[largerSum]
        sum2 = sums[smallerSum] + zeros[smallerSum]
        print("sums :", largerSum, sum1, zeros[largerSum], 
                ",", smallerSum, sum2, zeros[smallerSum])

        if (sum1 == sum2 
            or (sum1 > sum2 and zeros[smallerSum] > 0) 
            or (sum2 > sum1 and zeros[largerSum] > 0)):
            return max(sum1, sum2)
        else:
            return -1

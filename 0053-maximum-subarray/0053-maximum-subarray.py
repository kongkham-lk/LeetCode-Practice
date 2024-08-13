class Solution(object):
    def maxSubArray(self, nums):
        """
        :type nums: List[int]
        :rtype: int
        """

        maxSum = nums[0]
        sumTemp = 0

        for n in nums:
            #print("n: ", n)

            sumTemp += n
            #print("sumTemp: ", sumTemp)

            if maxSum < sumTemp:
                maxSum = sumTemp
            #print("maxSum: ", maxSum, "\n")

            if sumTemp < 0:
                sumTemp = 0

        return maxSum

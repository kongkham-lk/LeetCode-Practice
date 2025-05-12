class Solution:
    def productExceptSelf(self, nums: List[int]) -> List[int]:
        totalProd = 1
        zeros = 0
        temp = 1
        res = []
        for n in nums:
            if n is not 0:
                totalProd = totalProd * n
            else:
                zeros = zeros + 1

        # print(res)
        if zeros > 1:
            for n in nums:
                res.append(0)
            return res
        elif zeros > 0:
            temp = 0
            
        for n in nums:
            # print(n)
            if (n is 0):
                res.append(totalProd)
            else:
                prod = totalProd // n * temp
                res.append(prod)
        return res
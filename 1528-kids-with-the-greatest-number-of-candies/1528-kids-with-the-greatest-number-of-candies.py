class Solution:
    def kidsWithCandies(self, candies: List[int], extraCandies: int) -> List[bool]:
        largest = max(candies)
        res = []
        for c in candies:
            if c + extraCandies >= largest:
                res.append(True)
            else:
                res.append(False)
        return res
        
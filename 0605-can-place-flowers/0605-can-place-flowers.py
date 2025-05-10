class Solution:
    def canPlaceFlowers(self, flowerbed: List[int], n: int) -> bool:
        def countEmptyPlot(flowerbed: List[int]) -> int:
            plot = 0
            empty = True
            for i in range(len(flowerbed)-1):
                if flowerbed[i] == 0 and flowerbed[i+1] == 0:
                    if empty == True:
                        plot += 1
                        empty = False
                        flowerbed[i] = 1
                    else:
                        empty = True
                else:
                    empty = False
            if (flowerbed[len(flowerbed)-2] == 0 
                and flowerbed[len(flowerbed)-1] == 0):
                plot += 1
            return plot
        
        return countEmptyPlot(flowerbed) >= n
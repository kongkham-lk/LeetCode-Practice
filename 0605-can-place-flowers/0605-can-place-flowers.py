class Solution:
    def canPlaceFlowers(self, flowerbed: List[int], n: int) -> bool:
        def countEmptyPlot(flowerbed: List[int]) -> int:
            if len(flowerbed) == 1 and flowerbed[0] == 0:
                return 1

            plot = 0
            empty = True

            if (flowerbed[0] == 0 
                and flowerbed[1] == 0):
                plot += 1
                flowerbed[0] = 1
            for i in range(0,len(flowerbed)-1):
                if (flowerbed[i-1] == 0 
                    and flowerbed[i] == 0 
                    and flowerbed[i+1] == 0):
                    plot += 1
                    flowerbed[i] = 1
            if (flowerbed[len(flowerbed)-2] == 0 
                and flowerbed[len(flowerbed)-1] == 0):
                plot += 1
            return plot
        
        foundPlot = countEmptyPlot(flowerbed)
        print("found plantable: ", foundPlot)
        return foundPlot >= n
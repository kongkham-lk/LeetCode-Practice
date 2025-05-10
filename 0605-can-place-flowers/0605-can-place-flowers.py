class Solution:
    def canPlaceFlowers(self, flowerbed: List[int], n: int) -> bool:
        def countEmptyPlot(flowerbed: List[int]) -> int:
            if len(flowerbed) == 1 and flowerbed[0] == 0:
                return 1

            plot = 0
            empty = True
            tempPlot = flowerbed.copy()
            if (tempPlot[0] == 0 
                and tempPlot[1] == 0):
                plot += 1
                tempPlot[0] = 1
            for i in range(0,len(tempPlot)-1):
                if (tempPlot[i-1] == 0 
                    and tempPlot[i] == 0 
                    and tempPlot[i+1] == 0):
                    plot += 1
                    tempPlot[i] = 1
            if (tempPlot[len(tempPlot)-2] == 0 
                and tempPlot[len(tempPlot)-1] == 0):
                plot += 1
            return plot
            
        return countEmptyPlot(flowerbed) >= n
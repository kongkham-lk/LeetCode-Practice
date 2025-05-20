public class Solution {
    public int NumIslands(char[][] grid) {
        if (grid.Length < 0) return 0;
        
        // // For debugging
        // foreach(var r in grid) {
        //     Console.Write("[ ");
        //     foreach (var c in r)
        //         Console.Write(c + " ");
        //     Console.Write("]\n");
        // }

        int res = 0;
        for (int i = 0; i < grid.Length; i++) {
            for (int j = 0; j < grid[0].Length; j++) {
                if (grid[i][j].Equals('1')) {
                    res++;
                    ExploreLand(grid, i, j);
                }
            }
        }
        return res;
    }

    private void ExploreLand(char[][] grid, int i, int j) {
        if (i < 0 || i >= grid.Length || j < 0 || j >= grid[0].Length || !grid[i][j].Equals('1')) return;
        
        grid[i][j] = '0';

        ExploreLand(grid, i-1, j);
        ExploreLand(grid, i+1, j);
        ExploreLand(grid, i, j-1);
        ExploreLand(grid, i, j+1);
    }
}
public class Solution {

    public IList<IList<int>> PacificAtlantic(int[][] heights) {
        int ROW = heights.Length;
        int COL = heights[0].Length;
        HashSet<(int, int)> pac = new HashSet<(int, int)>();
        HashSet<(int, int)> atl = new HashSet<(int, int)>();

        IList<IList<int>> res = new List<IList<int>>();
        for (int i = 0; i < heights[0].Length; i++) {
            Dfs(heights, 0, i, pac, heights[0][i]);
            Dfs(heights, ROW-1, i, atl, heights[ROW-1][i]);
        }
        for (int i = 0; i < heights.Length; i++) {
            Dfs(heights, i, 0, pac, heights[i][0]);
            Dfs(heights, i, COL-1, atl, heights[i][COL-1]);
        }

        for (int i = 0; i < heights.Length; i++) {
            for (int j = 0; j < heights[i].Length; j++) {
                if (pac.Contains((i, j)) && atl.Contains((i, j)))
                    res.Add(new List<int>() {i, j});
            }
        }
        return res;
    }

    private void Dfs(int[][] heights, int i, int j, HashSet<(int, int)> visited, int prevHieght) {
        // Console.WriteLine(i + ", " + j);
        if (i < 0 || j < 0 || i >= heights.Length || j >= heights[0].Length) return;
        else if (visited.Contains((i, j)) || heights[i][j] < prevHieght) return;

        visited.Add((i, j));
        
        Dfs(heights, i-1, j, visited, heights[i][j]);
        Dfs(heights, i+1, j, visited, heights[i][j]);
        Dfs(heights, i, j-1, visited, heights[i][j]);
        Dfs(heights, i, j+1, visited, heights[i][j]);
    }
}
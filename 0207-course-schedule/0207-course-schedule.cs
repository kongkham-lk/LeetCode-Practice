public class Solution {
    Dictionary<int, List<int>> memo = new Dictionary<int, List<int>>();
    HashSet<int> visited = new HashSet<int>();

    public bool CanFinish(int numCourses, int[][] prerequisites) {
        // Initialize graph
        for (int i = 0; i < numCourses; i++)
            memo.Add(i, new List<int>());
        foreach(int[] c in prerequisites)
            memo[c[1]].Add(c[0]);

        // Check possible
        for (int i = 0; i < numCourses; i++) {
            if (!Dfs(i))
                return false;
        }
        return true;;
    }

    private bool Dfs(int tar) {
        if (visited.Contains(tar)) return false;
        if (memo[tar].Count == 0) return true;

        visited.Add(tar);
        foreach (int c in memo[tar]) {
            if (!Dfs(c))
                return false;
        }
        visited.Remove(tar); // remove the current visited, since the current course might by visited multiple times
        memo[tar].Clear(); // if it's possible course, clear all the prereq so that no need to go in to check again => mark this as possible course

        return true;
    }
}

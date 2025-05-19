public class Solution {
    HashSet<string> res = new HashSet<string>();
    bool[,] visited;
    int rowSize;
    int colSize;

    public IList<string> FindWords(char[][] board, string[] words) {
        TrieNode root = new TrieNode();
        rowSize = board.Length;
        colSize = board[0].Length;
        visited = new bool[rowSize,colSize];

        // merge all the word with the same partial string
        foreach (string w in words)
            root.Add(w);

        // iterate through the list only once 
        // see if any of char match with any target word
        for (int i = 0; i < rowSize; i++)
            for (int j = 0; j < colSize; j++)
                Dfs(board, i, j, root, "");

        return res.ToList();
    }

    private void Dfs(char[][] board, int r, int c, TrieNode curr, string word) {
        if (r < 0 || r >= rowSize || c < 0 || c >= colSize
            || visited[r,c] 
            || !curr.child.ContainsKey(board[r][c]))
            return;

        curr = curr.child[board[r][c]];
        word += board[r][c];
        visited[r,c] = true;

        if (curr.isLeaf)
            res.Add(word);

        Dfs(board, r-1, c, curr, word);
        Dfs(board, r+1, c, curr, word);
        Dfs(board, r, c-1, curr, word);
        Dfs(board, r, c+1, curr, word);

        visited[r,c] = false;
    }
}

public class TrieNode {
    public Dictionary<char, TrieNode> child = new Dictionary<char, TrieNode>();
    public bool isLeaf = false;

    public void Add(string word) {
        TrieNode curr = this;
        foreach (char c in word) {
            if (!curr.child.ContainsKey(c))
                curr.child.Add(c, new TrieNode());
            curr = curr.child[c];
        }
        curr.isLeaf = true;
    }
}
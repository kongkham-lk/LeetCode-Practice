public class Solution {
    HashSet<(int, int)> dp = new HashSet<(int, int)>();
    public bool Exist(char[][] board, string word) {
        for (int i = 0; i < board.Length; i++) {
            for (int j = 0; j < board[i].Length; j++) {
                if (FindWord(board, i, j, word, 0))
                    return true;
            }
        }
        return false;
    }

    private bool FindWord(char[][] board, int i, int j, string word, int c) {
        if (c == word.Length)
            return true;
        else if (i < 0 || j < 0 || i >= board.Length || j >= board[i].Length 
            || dp.Contains((i, j)) || !board[i][j].Equals(word[c])) 
            return false;
        
        dp.Add((i, j));
        c++;
        bool res = FindWord(board, i, j-1, word, c) 
            || FindWord(board, i, j+1, word, c) 
            || FindWord(board, i-1, j, word, c) 
            || FindWord(board, i+1, j, word, c);
        dp.Remove((i, j));

        return res;
    }
}
public class Solution {
    int rSize, cSize;
    HashSet<(int, int)> dp = new HashSet<(int, int)>();
    public bool Exist(char[][] board, string word) {
        rSize = board.Length;
        cSize = board[0].Length;
        // look for the next new position that match word[0]
        for (int i = 0; i < rSize; i++) {
            for (int j = 0; j < cSize; j++) {
                if (FindWord(board, i, j, word, 0))
                    return true;
            }
        }
        return false;
    }

    private bool FindWord(char[][] board, int i, int j, string word, int c) {
        if (c == word.Length)
            return true;
        else if (i < 0 || j < 0 
            || i >= rSize || j >= cSize 
            || dp.Contains((i, j)) 
            || !board[i][j].Equals(word[c])) 
            return false;
        
        dp.Add((i, j)); // memo when there is match char
        c++;
        bool res = FindWord(board, i, j-1, word, c) 
            || FindWord(board, i, j+1, word, c) 
            || FindWord(board, i-1, j, word, c) 
            || FindWord(board, i+1, j, word, c);
        dp.Remove((i, j)); // remove the last add match and looking for a new match on different direction

        return res;
    }
}
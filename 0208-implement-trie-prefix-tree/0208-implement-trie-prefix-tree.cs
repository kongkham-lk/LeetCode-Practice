public class TrieNode {
    public TrieNode[] children = new TrieNode[26];
    public bool isLeaf = false;
}

public class Trie {
    TrieNode root;

    public Trie() {
        root = new TrieNode();
    }
    
    public void Insert(string word) {
        TrieNode curr = root;
        foreach (Char c in word) {
            int i = c - 'a';
            if (curr.children[i] is null) {
                TrieNode newNode = new TrieNode();
                curr.children[i] = newNode;
            }
            curr = curr.children[i];
        }
        curr.isLeaf = true;
    }
    
    public bool Search(string word) {
        TrieNode curr = root;
        foreach (Char c in word) {
            int i = c - 'a';
            if (curr.children[i] is null) return false;
            curr = curr.children[i];
        }
        if (curr.isLeaf == true) return true;
        return false;
    }
    
    public bool StartsWith(string prefix) {
        TrieNode curr = root;
        foreach (Char c in prefix) {
            int i = c - 'a';
            if (curr.children[i] is null) return false;
            curr = curr.children[i];
        }
        return true;
    }
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */
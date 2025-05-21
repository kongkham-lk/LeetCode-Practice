/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    public Node CloneGraph(Node node) {
        Dictionary<int, Node> memo = new Dictionary<int, Node>();
        return DeepClone(node, memo);
    }

    private Node DeepClone(Node node, Dictionary<int, Node> memo) {
        if (node is null) return null;
        if (memo.ContainsKey(node.val)) return memo[node.val];

        Node copy = new Node(node.val);
        copy.neighbors = new List<Node>();
        memo.Add(node.val, copy);
        
        foreach (Node subNode in node.neighbors)
            copy.neighbors.Add(DeepClone(subNode, memo));
            
        return copy;
    }
}
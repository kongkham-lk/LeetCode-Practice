/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public TreeNode InvertTree(TreeNode root) {
        if (root == null)
            return root;
        
        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);

        while (q.Any()) { // use breath first search to iterate through each layer node
            TreeNode curr = q.Dequeue();
            if (curr.left != null) q.Enqueue(curr.left);
            if (curr.right != null) q.Enqueue(curr.right);
            
            // Swap node
            TreeNode temp = curr.left;
            curr.left = curr.right;
            curr.right = temp;
        }
        return root;
    }
}
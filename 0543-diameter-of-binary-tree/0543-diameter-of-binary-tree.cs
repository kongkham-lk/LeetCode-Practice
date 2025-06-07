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
    int res = 0;
    public int DiameterOfBinaryTree(TreeNode root) {
        Dfs(root);
        return res;
    }

    private int Dfs(TreeNode curr) {
        if (curr is null) return 0;
        
        int l = Dfs(curr.left);
        int r = Dfs(curr.right);

        res = Math.Max(res, l + r);
        return Math.Max(l, r) + 1;
    }
}
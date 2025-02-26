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
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        if (root == null && subRoot == null)
            return true;
        else if (root == null && subRoot != null || root != null && subRoot == null)
            return false;

        if (CompareSubTree(root, subRoot))
            return true;

        if (IsSubtree(root.left, subRoot))
            return true;

        if (IsSubtree(root.right, subRoot))
            return true;

        return false;
    }

    public bool CompareSubTree(TreeNode root, TreeNode subRoot) {
        if (root == null && subRoot == null)
            return true;
        else if (root == null && subRoot != null || root != null && subRoot == null)
            return false;

        if (root.val == subRoot.val)
            return CompareSubTree(root.left, subRoot.left) 
                    && CompareSubTree(root.right, subRoot.right);
    
        return false;
    }
}
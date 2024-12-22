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
    public int KthSmallest(TreeNode root, int k)
    {
        Stack<TreeNode> memo = new Stack<TreeNode>();
        return findKthSmallest(root, k, memo);
    }

    private int findKthSmallest(TreeNode curr, int k, Stack<TreeNode> memo)
    {
        while (curr != null)
        {
            memo.Push(curr);
            curr = curr.left;
        }

        while (memo.Any())
        {
            k--;
            curr = memo.Pop();

            if (k == 0)
                return curr.val;

            if (curr.right != null)
                return findKthSmallest(curr.right, k, memo);
        }

        return -1;
    }
}
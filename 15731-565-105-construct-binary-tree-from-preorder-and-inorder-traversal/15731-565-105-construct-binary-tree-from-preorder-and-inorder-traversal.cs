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
    int[] preorder = null;
    int[] inorder = null;
    int size = 0;
    int preIndex = 0;
    Dictionary<int, int> memo = new Dictionary<int, int>();

    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        this.preorder = preorder;
        this.inorder = inorder;
        size = inorder.Length;

        for (int i = 0; i < size; i++)
            memo[inorder[i]] = i;

        return Dfs(0, inorder.Length - 1);
    }

    private TreeNode Dfs(int start, int end) {
        if (end - start == 0) {
            // Console.WriteLine("base case: " + inorder[end] + ", preIndex: " + preIndex);
            preIndex++;
            return new TreeNode(inorder[end]);
        }

        if (end - start < 0 || start < 0 || end > size - 1 || preIndex > size - 1)
            return null;

        // Console.WriteLine("indexing preOrder: " + preIndex + ", preorder.length: " + preorder.Length);
        int targetPre = preorder[preIndex];
        // Console.WriteLine("norm case: " + targetPre + ", preIndex: " + preIndex);
        preIndex++;
        TreeNode curr = new TreeNode(targetPre);
        int targetInIndex = memo[targetPre];
        
        curr.left = Dfs(start, targetInIndex - 1);
        curr.right = Dfs(targetInIndex + 1, end);
        return curr;
    }
    
    private int FindTargetInOrder(int targetPre) {
        // Console.WriteLine("FindTargetInOrder()");
        for (int i = 0; i < size; i++) {
            if (inorder[i] == targetPre)
                return i;
        }
        return -1;
    }
}
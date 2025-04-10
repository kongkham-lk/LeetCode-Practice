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
        public int MaxPathSum(TreeNode root)
        {
            int res = Int32.MinValue;
            res = Math.Max(Dfs(root, ref res), res);
            return res;
        }

        public int Dfs(TreeNode root, ref int res)
        {
            TreeNode curr = root;

            int l = Int32.MinValue;
            int r = l;

            if (curr.left is null && curr.right is null)
                return curr.val;
            if (curr.left != null)
                l = Dfs(curr.left, ref res);
            if (curr.right != null)
                r = Dfs(curr.right, ref res);
            
            Console.WriteLine("out: " + curr.val + ", L: " + l + ", R: " + r + ", res: " + res);
            int largest = Math.Max(l, r);

            if (curr.val < 0)
                res = Math.Max(res, largest);

            if (root.left != null && root.right != null)
            {
                List<int> temp = new List<int>() {curr.val + l + r, curr.val + l, curr.val + r, curr.val, res};
                Console.Write(curr.val + ", " + largest + ", " + res);
                res = temp.Max();
                Console.WriteLine(" -> res: " + res + " <<<< NON NULL >>>>");

            }
            else
            {
                List<int> temp = new List<int>() {curr.val + largest, curr.val, res};
                Console.Write(curr.val + ", " + largest + ", " + res);
                res = temp.Max();
                Console.WriteLine(" -> res: " + res);
            }
            
            return Math.Max(curr.val + largest, curr.val);
        }
}
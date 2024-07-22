using System;
namespace Step_By_Step_Directions_From_a_Binary_Tree_Node_to_Another
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class ObjectInfo
    {
        public TreeNode Initialize(int[] inputs)
        {
            TreeNode root = new(inputs[0]);
            Queue<TreeNode> q = new();
            q.Enqueue(root);

            for (int i = 1; i < inputs.Length; i += 2)
            {
                TreeNode curNode = q.Dequeue();
                if (inputs[i] != -1)
                {
                    TreeNode l = new(inputs[i]);
                    curNode.left = l;
                    q.Enqueue(l);
                }
                if (i+1 < inputs.Length && inputs[i + 1] != -1)
                {
                    TreeNode r = new(inputs[i + 1]);
                    curNode.right = r;
                    q.Enqueue(r);
                }
            }
            return root;
        }


        public void PrintTreeNode(TreeNode root, int testCaseNum)
        {
            Queue<TreeNode> q = new();
            q.Enqueue(root);

            Console.Write($"test {testCaseNum}: [ ");

            while (q.Any())
            {
                TreeNode curNode = q.Dequeue();
                Console.Write(curNode == null ? "null" : curNode.val);
                Console.Write(" ");

                if (curNode == null)
                    continue;

                q.Enqueue(curNode.left);
                q.Enqueue(curNode.right);
            }
            Console.WriteLine("]");
        }
    }
}


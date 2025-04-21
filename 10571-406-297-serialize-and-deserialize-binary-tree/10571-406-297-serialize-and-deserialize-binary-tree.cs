/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Codec {

    // Encodes a tree to a single string.
    public string serialize(TreeNode root) {
        Queue<TreeNode> q = new Queue<TreeNode>();
        string res = "";
        q.Enqueue(root);
        while (q.Any()) {
            TreeNode curr = q.Dequeue();
            if (curr is null) {
                res += " ,";
                continue;
            } else
                res += curr.val + ",";
                
            q.Enqueue(curr.left);
            q.Enqueue(curr.right);
        }
        Console.WriteLine(res + "\n");
        return res;
    }

    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data) {
        if (data.Equals(" ,") || !data.Any())
            return null;

        string temp = "";
        int i = 0;

        while (i < data.Length && !data[i].Equals(',')) {
            temp += data[i];
            i++;
        }
        
        Queue<TreeNode> q = new Queue<TreeNode>();
        TreeNode root = new TreeNode(Int32.Parse(temp));
        q.Enqueue(root);
        temp = "";
        i++;

        while (i < data.Length) {
            // Console.WriteLine("at >> " + data[i] + ", " + data[i+1]);
            TreeNode curr = q.Dequeue();
            if (curr != null) {
                int count = 0;
                TreeNode[] num = new TreeNode[2];
                while (i < data.Length && count < 2) {
                    // Console.WriteLine("at >> " + data[i]);
                    if (!data[i].Equals(',')) {
                        temp += data[i];
                        i++;
                    } else {
                        // Console.WriteLine("found: " + temp);
                        num[count] = temp.Equals(" ") ? null : new TreeNode(Int32.Parse(temp));
                        count++;
                        i++;
                        temp = "";
                    }
                }
                
                curr.left = num[0];
                curr.right = num[1];
                q.Enqueue(curr.left);
                q.Enqueue(curr.right);
                // Console.WriteLine(curr.val + ", " + data[i] + ", " + data[i+1] + ", ");
            }
        }
        return root;
    }
}

// Your Codec object will be instantiated and called as such:
// Codec ser = new Codec();
// Codec deser = new Codec();
// TreeNode ans = deser.deserialize(ser.serialize(root));
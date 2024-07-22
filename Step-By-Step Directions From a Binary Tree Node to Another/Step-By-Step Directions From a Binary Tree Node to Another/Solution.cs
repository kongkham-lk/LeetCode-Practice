using System;
namespace Step_By_Step_Directions_From_a_Binary_Tree_Node_to_Another
{
    public class Solution
    {
        public string GetDirections(TreeNode root, int startValue, int destValue)
        {
            string s = "";
            string d = "";
            string result = "";

            FindNode(root, startValue, ref s);
            FindNode(root, destValue, ref d);

            Console.WriteLine("s: " + s); // include all the direction from the root
            Console.WriteLine("d: " + d); // include all the direction from the root

            // getting valid index for both string.
            int minStep = Math.Min(s.Length, d.Length);
            bool foundDiffDir = false;
            int excludeDirCounter = 0;

            // in case that there is one that has not length. E.g. found destVal right away
            if (minStep != 0)
            {
                // only iterate within the minStep value in case that the dest is at the same side.
                // E.g. after found startVal, jus need to step up 1-2 then go down right and found.
                for (int i = 0; i < minStep; i++)
                {
                    // in case both find logic node of each target node travel down the same sub Node,
                    // the "U" should start into account when the direction is different
                    if (!foundDiffDir && s[minStep - 1 - i] == d[i])
                        excludeDirCounter++;
                    else
                    {
                        foundDiffDir = true;
                        result += "U";
                    }
                }
            }
            else
            {
                for (int i = 0; i < s.Length; i++)
                    result += "U";
            }

            for (int i = d.Length - 1; i >= excludeDirCounter; i--)
                result = result + d[i];

            return result;
        }

        private bool FindNode(TreeNode node, int targetVal, ref string result)
        {
            if (node == null)
                return false;
            else if (node.val == targetVal)
                return true;

            if (node.left != null && FindNode(node.left, targetVal, ref result))
            {
                result = result + "L";
                return true;
            }

            if (node.right != null && FindNode(node.right, targetVal, ref result))
            {
                result = result + "R";
                return true;
            }

            return false;
        }
    }
}


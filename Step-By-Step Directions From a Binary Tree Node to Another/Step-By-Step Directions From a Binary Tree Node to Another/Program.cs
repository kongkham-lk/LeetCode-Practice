using Step_By_Step_Directions_From_a_Binary_Tree_Node_to_Another;

ObjectInfo item = new();
Solution solution = new();
int[] input1 = { 5, 1, 2, 3, -1, 6, 4 };
int[] input2 = { 1, -1, 10, 12, 13, 4, 6, -1, 15, -1, -1, 5, 11, -1, 2, 14, 7, -1, 8, -1, -1, -1, 9, 3 };
int[] input3 = { 1, 2 };
int[] input4 = { 13, 5, 4, 7, -1, 8, 6, 3, -1, -1, 12, 9, 1, -1, -1, 11, -1, -1, 10, -1, -1, -1, -1, 2 };

//TreeNode test1 = item.Initialize(input1);
//item.PrintTreeNode(test1, 1);
//Console.WriteLine("Expect: UURL\n" + "Output: " + solution.GetDirections(test1, 3, 6) + "\n");

//TreeNode test2 = item.Initialize(input2);
//item.PrintTreeNode(test2, 2);
//Console.WriteLine("Expect: UURR\n" + "Output: " + solution.GetDirections(test2, 6, 15) + "\n");

//TreeNode test3 = item.Initialize(input3);
//item.PrintTreeNode(test3, 3);
//Console.WriteLine("Expect: U\n" + "Output: " + solution.GetDirections(test3, 2, 1) + "\n");

TreeNode test4 = item.Initialize(input4);
item.PrintTreeNode(test4, 4);
Console.WriteLine("Expect: UUURRLRL\n" + "Output: " + solution.GetDirections(test4, 3, 2) + "\n");
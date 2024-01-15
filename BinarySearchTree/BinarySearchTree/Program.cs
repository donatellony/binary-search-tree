using BinarySearchTree;

var tree = new BinaryTreeNode(9);
tree.Insert(4);
tree.Insert(20);
tree.Insert(1);
tree.Insert(6);
tree.Insert(15);
tree.Insert(170);


Console.WriteLine(tree.GetFormattedJson());

Console.WriteLine(tree.LookupIterative(170));
Console.WriteLine(tree.LookupIterative(171));
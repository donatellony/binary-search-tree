using BinarySearchTree;

var tree = new BinaryTreeNode(9);
tree.Insert(4);
tree.Insert(20);
tree.Insert(1);
tree.Insert(6);
tree.Insert(15);
tree.Insert(170);

Console.WriteLine("The entire tree");
Console.WriteLine(tree.GetFormattedJson());

Console.WriteLine("Lookup Iterative");
Console.WriteLine(tree.LookupIterative(170)?.GetFormattedJson());
Console.WriteLine(tree.LookupIterative(171)?.GetFormattedJson());
Console.WriteLine("Lookup Recursive");
Console.WriteLine(tree.Lookup(170)?.GetFormattedJson());
Console.WriteLine(tree.Lookup(171)?.GetFormattedJson());
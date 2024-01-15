using System.Text.Json;

namespace BinarySearchTree;

public class BinaryTreeNode(int value)
{
    public int Value { get; init; } = value;
    public BinaryTreeNode? Left { get; set; }
    public BinaryTreeNode? Right { get; set; }

    private static readonly JsonSerializerOptions SerializerOptions = new()
    {
        WriteIndented = true
    };

    public void Insert(int value)
    {
        if (value < Value)
        {
            if (Left is null)
            {
                Left = new BinaryTreeNode(value);
            }
            else
            {
                Left.Insert(value);
            }
        }
        else
        {
            if (Right is null)
            {
                Right = new BinaryTreeNode(value);
            }
            else
            {
                Right.Insert(value);
            }
        }
    }

    public BinaryTreeNode? Lookup(int value)
    {
        if (value == Value)
            return this;

        if (value < Value)
        {
            return Left?.Lookup(value);
        }

        return Right?.Lookup(value);
    }

    public BinaryTreeNode? LookupIterative(int value)
    {
        var currentNode = this;
        while (currentNode is not null)
        {
            if (value == currentNode.Value)
                return currentNode;

            if (value < currentNode.Value)
            {
                currentNode = currentNode.Left;
            }
            else
            {
                currentNode = currentNode.Right;
            }
        }

        return null; // Should not happen
    }

    public string GetFormattedJson()
    {
        return JsonSerializer.Serialize(this, SerializerOptions);
    }
}
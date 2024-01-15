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

    public bool Lookup(int value)
    {
        if (value == Value)
            return true;

        if (value < Value)
        {
            return Left is not null && Left.Lookup(value);
        }

        return Right is not null && Right.Lookup(value);
    }

    public bool LookupIterative(int value)
    {
        int currentNodeValue;
        var currentNode = this;
        do
        {
            currentNodeValue = currentNode.Value;
            if (value == currentNodeValue)
                return true;

            var leftNode = currentNode.Left;
            var rightNode = currentNode.Right;
            if (value < currentNodeValue)
            {
                if (leftNode is null)
                    return false;
                currentNode = leftNode;
            }
            else
            {
                if (rightNode is null)
                    return false;
                currentNode = rightNode;
            }
        } while (value != currentNodeValue);

        return false; // Should not happen
    }

    public string GetFormattedJson()
    {
        return JsonSerializer.Serialize(this, SerializerOptions);
    }
}
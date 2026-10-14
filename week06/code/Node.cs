public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // Problem 1: Insert Unique Values Only
        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else if (value > Data)
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
        // If value == Data, do nothing (duplicates are not allowed)
    }

    public bool Contains(int value)
    {
        // Problem 2: Contains
        if (value == Data)
        {
            return true;
        }
        else if (value < Data)
        {
            return Left is not null && Left.Contains(value);
        }
        else
        {
            return Right is not null && Right.Contains(value);
        }
    }

    public int GetHeight()
    {
        // Problem 4: Tree Height
        int leftHeight = Left?.GetHeight() ?? 0;
        int rightHeight = Right?.GetHeight() ?? 0;
        return 1 + Math.Max(leftHeight, rightHeight);
    }
}
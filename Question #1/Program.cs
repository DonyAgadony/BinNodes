namespace BinNodes;
class BinNode<T>
{
    private T value;
    private BinNode<T>? left, right;

    public BinNode(T value)
    {
        this.value = value;
    }

    public BinNode(T value, BinNode<T> left, BinNode<T> right)
    {
        this.value = value;
        this.left = left;
        this.right = right;
    }


    public T GetValue()
    {
        return value;
    }

    public void SetValue(T value)
    {
        this.value = value;
    }

    public BinNode<T>? GetLeft()
    {
        return left;
    }

    public void SetLeft(BinNode<T>? left)
    {
        this.left = left;
    }

    public bool HasLeft()
    {
        return this.left != null;
    }

    public BinNode<T>? GetRight()
    {
        return right;
    }

    public void SetRight(BinNode<T>? right)
    {
        this.right = right;
    }

    public bool HasRight()
    {
        return this.right != null;
    }
}
class Question1
{
    public static int GetSmaller10(BinNode<double> root)
    {
        int count = 0;
        if (root.GetValue() < 10) { count++; }
        if (root.GetLeft() != null)
        {
            count += GetSmaller10(root.GetLeft());
        }
        if (root.GetRight() != null) { count += GetSmaller10(root.GetRight()); }
        return count;
    }
}


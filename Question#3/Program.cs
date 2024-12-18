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

class Question2
{
    public static bool TreeContains<T>(BinNode<T> root, T value)
    {
        if (root.GetValue().Equals(value)) return false;
        if (root.GetLeft() != null)
        {
            return TreeContains(root.GetLeft(), value);
        }
        if (root.GetRight() != null)
        {
            return TreeContains(root.GetRight(), value);
        }
        return false;
    }
}
class Question3
{
    public static int GetHeight<T>(BinNode<T> root)
    {
        int heightLeft = 1;
        int heightRight = 1;
        if (root == null) { return 0; }
        if (root.GetLeft() != null)
        {
            heightLeft += GetHeight(root.GetLeft());
        }
        if (root.GetRight() != null)
        {
            heightRight += GetHeight(root.GetRight());
        }
        return Math.Max(heightLeft, heightRight);
    }
}
class Program
{
    public static void Main()
    {
        // Creating nodes from bottom to top
        var nodeD = new BinNode<int>(17);
        var nodeE = new BinNode<int>(0);
        var nodeH = new BinNode<int>(11);
        var nodeG = new BinNode<int>(3, nodeH, null);
        var nodeC = new BinNode<int>(241, nodeD, nodeE);
        var nodeF = new BinNode<int>(429, null, nodeG);
        var nodeB = new BinNode<int>(8, nodeC, nodeF);

        var nodeM = new BinNode<int>(616);
        var nodeL = new BinNode<int>(401, null, nodeM);
        var nodeN = new BinNode<int>(257);
        var nodeK = new BinNode<int>(1, nodeL, nodeN);
        var nodeJ = new BinNode<int>(2);
        var nodeP = new BinNode<int>(17);
        var nodeO = new BinNode<int>(241, nodeP, null);
        var nodeI = new BinNode<int>(8, nodeJ, nodeO);

        // Root node
        var root = new BinNode<int>(320, nodeB, nodeI);
        Console.WriteLine(Question3.GetHeight(root));
    }
}

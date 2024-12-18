﻿class BinNode<T>
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
using System;

public class CStack<T>
{
    private CNode<T> _head;
    private int _count;

    public bool IsEmpty { get { return _count == 0; } }
    public int Count { get { return _count; } }

    public void AddElement(T data)
    {
        CNode<T> node = new CNode<T>(data);
        node.Next = _head;
        _head = node;
        _count = _count + 1;
    }

    public T GetElement()
    {
        if (IsEmpty) throw new InvalidOperationException("Stack is empty!");

        CNode<T> temp = _head;
        _head = _head.Next;
        _count = _count - 1;

        return temp.Data;
    }

    public T GetHeadElement()
    {
        if (IsEmpty) throw new InvalidOperationException("Stack is empty!");
        return _head.Data;
    }
}
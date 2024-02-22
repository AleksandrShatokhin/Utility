using System;

public class CQueue<T>
{
    private CNode<T> _head;
    private CNode<T> _tail;
    private int _count;

    public bool IsEmpty { get { return _count == 0; } }
    public int Count { get { return _count; } }

    public T FirstElement
    {
        get
        {
            if (IsEmpty) throw new InvalidOperationException("Queue is empty");
            return _head.Data;
        }
    }

    public T LastElement
    {
        get
        {
            if (IsEmpty) throw new InvalidOperationException("Queue is empty");
            return _tail.Data;
        }
    }

    public void AddElement(T data)
    {
        CNode<T> node = new CNode<T>(data);
        CNode<T> temp = _tail;
        _tail = node;

        if (IsEmpty)
        {
            _head = _tail;
        }
        else
        {
            temp.Next = _tail;
        }

        _count = _count + 1;
    }

    public T GetElement()
    {
        if (IsEmpty) throw new InvalidOperationException("Queue is empty");

        T output = _head.Data;
        _head = _head.Next;
        _count = _count - 1;

        return output;
    }

    public bool Contains(T data)
    {
        CNode<T> current = _head;
        while (current != null)
        {
            if (current.Data.Equals(data))
            {
                return true;
            }
            current = current.Next;
        }
        return false;
    }

    public void Clear()
    {
        _head = null;
        _tail = null;
        _count = 0;
    }
}

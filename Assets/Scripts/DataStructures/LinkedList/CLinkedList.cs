public class CLinkedList<T>
{
    private CNode<T> _head;
    private CNode<T> _tail;
    private int _count;

    public bool IsEmpty { get { return _count == 0; } }
    public int Count { get { return _count; } }

    public void AddElement(T data)
    {
        CNode<T> node = new CNode<T>(data);

        if (_head == null)
        {
            _head = node;
        }
        else
        {
            _tail.Next = node;
        }

        _tail = node;
        _count = _count + 1;
    }

    public T GetHeadElement()
    {
        CNode<T> temp = _head;
        Remove(_head.Data);
        return temp.Data;
    }

    public bool Remove(T data)
    {
        CNode<T> current = _head;
        CNode<T> previous = null;

        while (current != null && current.Data != null)
        {
            if (current.Data.Equals(data))
            {
                if (previous != null)
                {
                    previous.Next = current.Next;

                    if (current.Next == null)
                    {
                        _tail = previous;
                    }
                }
                else
                {
                    _head = _head.Next;

                    if (_head == null)
                    {
                        _tail = null;
                    }
                }
                _count = _count - 1;
                return true;
            }
            previous = current;
            current = current.Next;
        }

        return false;
    }

    public void AddedInFirst(T data)
    {
        CNode<T> node = new CNode<T>(data);
        node.Next = _head;
        _head = node;

        if (IsEmpty)
        {
            _tail = _head;
        }

        _count = _count + 1;
    }

    public bool Contains(T data)
    {
        CNode<T> current = _head;
        while (current != null && current.Data != null)
        {
            if (current.Data.Equals(data)) return true;
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

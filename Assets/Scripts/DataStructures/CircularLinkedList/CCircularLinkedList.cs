public class CCircularLinkedList<T>
{
    private CNode<T> _head;
    private CNode<T> _tail;
    private int _count;

    public bool IsEmpty { get { return _count == 0; } }
    public int Count { get { return _count; } }

    public bool Contains(T data)
    {
        CNode<T> current = _head;

        if (current == null) return false;

        do
        {
            if (current.Data.Equals(data)) return true;
            current = current.Next;
        }
        while (current != _head);

        return false;
    }

    public void Add(T data)
    {
        CNode<T> node = new CNode<T>(data);

        if (_head == null)
        {
            _head = node;
            _tail = node;
            _tail.Next = _head;
        }
        else
        {
            node.Next = _head;
            _tail.Next = node;
            _tail = node;
        }
        _count = _count + 1;
    }

    public bool Remove(T data)
    {
        CNode<T> current = _head;
        CNode<T> previous = null;

        if (IsEmpty) return false;

        do
        {
            if (current.Data.Equals(data))
            {
                if (previous != null)
                {
                    previous.Next = current.Next;

                    if (current == _tail)
                    {
                        _tail = previous;
                    }
                }
                else
                {
                    if (_count == 1)
                    {
                        _head = _tail = null;
                    }
                    else
                    {
                        _head = current.Next;
                        _tail.Next = current.Next;
                    }
                }
                _count = _count - 1;
                return true;
            }

            previous = current;
            current = current.Next;
        } while (current != _head);

        return false;
    }

    public void Clear()
    {
        _head = null;
        _tail = null;
        _count = 0;
    }
}

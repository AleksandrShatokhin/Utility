public class CDoublyLinkedList<T>
{
    private CDoublyNode<T> _head;
    private CDoublyNode<T> _tail;
    private int _count;

    public bool IsEmpty { get { return _count == 0; } }
    public int Count { get { return _count; } }

    public void AddElement(T data)
    {
        CDoublyNode<T> node = new CDoublyNode<T>(data);

        if (_head == null)
        {
            _head = node;
        }
        else
        {
            _tail.Next = node;
            node.Previous = _tail;
        }
        _tail = node;
        _count = _count + 1;
    }

    public T GetHeadElement()
    {
        CDoublyNode<T> temp = _head;
        Remove(_head.Data);
        return temp.Data;
    }

    public bool Remove(T data)
    {
        CDoublyNode<T> current = _head;

        while (current != null)
        {
            if (current.Data.Equals(data))
            {
                break;
            }
            current = current.Next;
        }
        if (current != null)
        {
            if (current.Next != null)
            {
                current.Next.Previous = current.Previous;
            }
            else
            {
                _tail = current.Previous;
            }

            if (current.Previous != null)
            {
                current.Previous.Next = current.Next;
            }
            else
            {
                _head = current.Next;
            }
            _count = _count - 1;
            return true;
        }
        return false;
    }

    public bool Contains(T data)
    {
        CDoublyNode<T> current = _head;
        while (current != null)
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

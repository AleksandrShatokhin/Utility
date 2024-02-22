public class CCircularDoublyLinkedList<T>
{
    private CDoublyNode<T> _head;
    private int _count;

    public bool IsEmpty { get { return _count == 0; } }
    public int Count { get { return _count; } }

    public bool Contains(T data)
    {
        CDoublyNode<T> current = _head;

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
        CDoublyNode<T> node = new CDoublyNode<T>(data);

        if (_head == null)
        {
            _head = node;
            _head.Next = node;
            _head.Previous = node;
        }
        else
        {
            node.Previous = _head.Previous;
            node.Next = _head;
            _head.Previous.Next = node;
            _head.Previous = node;
        }
        _count = _count + 1;
    }

    public bool Remove(T data)
    {
        CDoublyNode<T> current = _head;
        CDoublyNode<T> removedItem = null;

        if (IsEmpty) return false;

        do
        {
            if (current.Data.Equals(data))
            {
                removedItem = current;
                break;
            }
            current = current.Next;
        }
        while (current != _head);

        if (removedItem != null)
        {
            if (_count == 1)
            {
                _head = null;
            }
            else
            {
                if (removedItem == _head)
                {
                    _head = _head.Next;
                }
                removedItem.Previous.Next = removedItem.Next;
                removedItem.Next.Previous = removedItem.Previous;
            }
            _count = _count - 1;
            return true;
        }
        return false;
    }

    public void Clear()
    {
        _head = null;
        _count = 0;
    }
}

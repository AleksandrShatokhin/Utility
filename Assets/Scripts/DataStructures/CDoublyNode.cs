public class CDoublyNode<T>
{
    public T Data { get; set; }
    public CDoublyNode<T> Previous { get; set; }
    public CDoublyNode<T> Next { get; set; }

    public CDoublyNode(T data)
    {
        Data = data;
    }
}
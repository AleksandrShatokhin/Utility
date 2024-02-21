public class CNode<T>
{
    public T Data { get; set; }
    public CNode<T> Next { get; set; }

    public CNode(T data)
    {
        Data = data;
    }
}

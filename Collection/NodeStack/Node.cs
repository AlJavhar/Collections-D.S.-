namespace Collection.NodeStack;

partial class Node<T>
{
    public Node(T data)
    {
        Data = data;
    }

    public T Data { get; set; }
    public Node<T> Next { get; set; }
}

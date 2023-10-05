using System.Collections;

namespace Collection.Queue;

public class Queue<T> : IEnumerable<T>
{
    Node<T> head; // головной/первый элемент
    Node<T> tail; // последний/хвостовой элемент
    int count;
    // добавление в очередь
    public void Enqueue(T data)
    {
        Node<T> node = new Node<T>(data);
        Node<T> tempNode = tail;
        tail = node;
        if (count == 0)
            head = tail;
        else
            tempNode.Next = tail;
        count++;
    }
    // удаление из очереди
    public T Dequeue()
    {
        if (count == 0)
            throw new InvalidOperationException();
        T output = head.Data;
        head = head.Next;
        count--;
        return output;
    }
    // получаем первый элемент
    public T First
    {
        get
        {
            if (IsEmpty)
                throw new InvalidOperationException();
            return head.Data;
        }
    }
    // получаем последний элемент
    public T Last
    {
        get
        {
            if (IsEmpty)
                throw new InvalidOperationException();
            return tail.Data;
        }
    }
    public int Count { get { return count; } }
    public bool IsEmpty { get { return count == 0; } }

    public void Clear()
    {
        head = null;
        tail = null;
        count = 0;
    }

    public bool Contains(T data)
    {
        Node<T> current = head;
        while (current != null)
        {
            if (current.Data.Equals(data))
                return true;
            current = current.Next;
        }
        return false;
    }
    IEnumerator<T> IEnumerable<T>.GetEnumerator()
    {
        Node<T> current = head;
        while (current != null)
        {
            yield return current.Data;
            current = current.Next;
        }
    }

    public IEnumerator GetEnumerator()
    {
        return ((IEnumerable)this).GetEnumerator();
    }
}

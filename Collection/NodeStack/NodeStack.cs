using System.Collections;

namespace Collection.NodeStack;

public class NodeStack<T> : IEnumerable<T>
{
    Node<T> head;
    int count;

    public bool IsEmpty
    {
        get { return count == 0; }
    }
    public int Count
    {
        get { return count; }
    }

    public void Push(T item)
    {
        // увеличиваем стек
        Node<T> node = new Node<T>(item);
        node.Next = head; // переустанавливаем верхушку стека на новый элемент
        head = node;
        count++;
    }
    public T Pop()
    {
        // если стек пуст, выбрасываем исключение
        if (IsEmpty)
            throw new InvalidOperationException("Стек пуст");
        Node<T> temp = head;
        head = head.Next; // переустанавливаем верхушку стека на следующий элемент
        count--;
        return temp.Data;
    }
    public T Peek()
    {
        if (IsEmpty)
            throw new InvalidOperationException("Стек пуст");
        return head.Data;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return ((IEnumerable)this).GetEnumerator();
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
}
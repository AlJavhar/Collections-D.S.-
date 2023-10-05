namespace Collection.Stack;

public class FixedStack<T>
{
    private T[] items; // элементы стека
    private int count;  // количество элементов
    const int n = 10;   // количество элементов в массиве по умолчанию
    public FixedStack()
    {
        items = new T[n];
    }
    public FixedStack(int length)
    {
        items = new T[length];
    }
    // пуст ли стек
    public bool IsEmpty
    {
        get { return count == 0; }
    }
    // размер стека
    public int Count
    {
        get { return count; }
    }
    // добвление элемента
    public void Push(T item)
    {
        // если стек заполнен, выбрасываем исключение
        if (count == items.Length)
            throw new InvalidOperationException("Переполнение стека");
        items[count++] = item;
    }
    // извлечение элемента
    public T Pop()
    {
        // если стек пуст, выбрасываем исключение
        if (IsEmpty)
            throw new InvalidOperationException("Стек пуст");
        T item = items[--count];
        items[count] = default(T); // сбрасываем ссылку
        return item;
    }
    // возвращаем элемент из верхушки стека
    public T Peek()
    {
        // если стек пуст, выбрасываем исключение
        if (IsEmpty)
            throw new InvalidOperationException("Стек пуст");
        return items[count - 1];
    }

    private void Resize(int max)
    {
        T[] tempItems = new T[max];
        for (int i = 0; i < count; i++)
            tempItems[i] = items[i];
        items = tempItems;
    }
}

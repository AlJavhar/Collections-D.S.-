using Collection.Dek;
using Collection.DoublyLinkedList;
using Collection.LinkedList;
using Collection.NodeStack;
using Collection.Stack;

MyLinkedList<string> linkedList = new MyLinkedList<string>
{
    "Aziz",
    "Muhammad og`am",
    "Normadjon"
};

foreach(var item in linkedList)
{
    Console.WriteLine(item);
}

Console.WriteLine("\n DoublyLinkedList: \n");

DoublyLinkedList<string> dounbleLink = new DoublyLinkedList<string>();

dounbleLink.Add("Normadjon");
dounbleLink.Add("Javohir");
dounbleLink.Add("Oypopuk");
dounbleLink.AddFirst("Katya");

foreach(var item in dounbleLink)
{
    Console.WriteLine(item);
}


dounbleLink.Remove("Oypopuk");

Console.WriteLine("");

foreach (var item in dounbleLink.BackEnumerator())
{
    Console.WriteLine(item);
}

Console.WriteLine("\n Stack: \n");
try
{
    FixedStack<string> fixedStack = new FixedStack<string>(8);
    fixedStack.Push("Katyaxon");
    fixedStack.Push("Valeriya");
    fixedStack.Push("Bodomgul");
    fixedStack.Push("Nappi");

    var head = fixedStack.Pop();
    Console.WriteLine(head);


    head = fixedStack.Peek();
    Console.WriteLine(head);
}
catch(InvalidOperationException ex)
{
    Console.WriteLine(ex.Message);
}


Console.WriteLine("\n Node stack \n");

NodeStack<string> stack = new NodeStack<string>();
stack.Push("Tom");
stack.Push("Alice");
stack.Push("Bob");
stack.Push("Kate");

foreach (var item in stack)
{
    Console.WriteLine(item);
}
Console.WriteLine();
string header = stack.Peek();
Console.WriteLine($"Верхушка стека: {header}");
Console.WriteLine();

header = stack.Pop();
foreach (var item in stack)
{
    Console.WriteLine(item);
}

Console.WriteLine("\n Queue \n");
Queue<string> queue = new Queue<string>();
queue.Enqueue("Kate");
queue.Enqueue("Sam");
queue.Enqueue("Alice");
queue.Enqueue("Tom");

foreach (string item in queue)
    Console.WriteLine(item);
Console.WriteLine();

Console.WriteLine();
string firstItem = queue.Dequeue();
Console.WriteLine($"Извлеченный элемент: {firstItem}");
Console.WriteLine();

foreach (string item in queue)
    Console.WriteLine(item);

Console.WriteLine("\n Deque \n");

Deque<string> usersDeck = new Deque<string>();
usersDeck.AddFirst("Alice");
usersDeck.AddLast("Kate");
usersDeck.AddLast("Tom");

foreach (string s in usersDeck)
    Console.WriteLine(s);

string removedItem = usersDeck.RemoveFirst();
Console.WriteLine("\n Удален: {0} \n", removedItem);

foreach (string s in usersDeck)
    Console.WriteLine(s);
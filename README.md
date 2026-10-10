C# Collections: Add, Remove, and Other Important Methods
Here is an interview-ready cheat sheet for Queue, Stack, List, HashSet, Dictionary, LinkedList, and other C# collections.
1. Collection methods at a glance
Collection	Add	Remove	Read / Search
Queue<T>	Enqueue()	Dequeue()	Peek()
Stack<T>	Push()	Pop()	Peek()
List<T>	Add()	Remove()	Find(), Contains()
HashSet<T>	Add()	Remove()	Contains()
Dictionary<K,V>	Add()	Remove()	TryGetValue()
LinkedList<T>	AddLast()	Remove()	Find()
SortedSet<T>	Add()	Remove()	Contains()
PriorityQueue<T,P>	Enqueue()	Dequeue()	Peek()
2. Queue — FIFO
First In, First Out.
Queue<int> queue = new Queue<int>();

// Add
queue.Enqueue(10);
queue.Enqueue(20);
queue.Enqueue(30);

// Read first element
Console.WriteLine(queue.Peek());    // 10

// Remove first element
Console.WriteLine(queue.Dequeue()); // 10

// Check
Console.WriteLine(queue.Contains(20)); // True
Console.WriteLine(queue.Count);        // 2


- Enqueue() — add an element.
- Dequeue() — remove and return the first element.
- Peek() — read the first element without removing it.
- Clear() — remove all elements.
3. Stack — LIFO
Last In, First Out.
Stack<int> stack = new Stack<int>();

// Add
stack.Push(10);
stack.Push(20);
stack.Push(30);

// Read top element
Console.WriteLine(stack.Peek()); // 30

// Remove top element
Console.WriteLine(stack.Pop());  // 30

// Check
Console.WriteLine(stack.Contains(10)); // True
Console.WriteLine(stack.Count);        // 2


- Push() — add an element to the top.
- Pop() — remove and return the top element.
- Peek() — read the top element.
- Clear() — remove all elements.
4. List — Ordered, index-based collection
List<int> numbers = new List<int>();

// Add
numbers.Add(10);
numbers.Add(20);
numbers.Add(30);

// Add at a specific index
numbers.Insert(1, 15);
// 10, 15, 20, 30

// Remove by value
numbers.Remove(20);

// Remove by index
numbers.RemoveAt(0);

// Read by index
Console.WriteLine(numbers[0]); // 15

// Search
Console.WriteLine(numbers.Contains(30)); // True

// Remove all elements
numbers.Clear();


Important methods:
Method	Purpose
Add()	Add one element
AddRange()	Add multiple elements
Insert()	Add at a specific index
Remove()	Remove the first matching value
RemoveAt()	Remove by index
RemoveAll()	Remove elements matching a condition
Contains()	Check whether a value exists
Find()	Find the first matching element
Sort()	Sort the list
Clear()	Remove everything
5. HashSet — Unique elements only
A HashSet<T> does not store duplicate values.
HashSet<int> numbers = new HashSet<int>();

// Add
numbers.Add(10);
numbers.Add(20);
numbers.Add(30);
numbers.Add(20); // Duplicate ignored

// Remove
numbers.Remove(10);

// Search
Console.WriteLine(numbers.Contains(20)); // True

// Count
Console.WriteLine(numbers.Count); // 2

// Clear
numbers.Clear();


Important methods:
- Add() — add a unique element; returns false if it already exists.
- Remove() — remove an element.
- Contains() — check whether an element exists.
- UnionWith() — combine elements from another collection.
- IntersectWith() — keep only common elements.
- ExceptWith() — remove elements found in another collection.
- Clear() — remove everything.
6. Dictionary — Key-value pairs
A dictionary stores data as a key and its associated value. Each key must be unique.
Dictionary<int, string> students =
    new Dictionary<int, string>();

// Add
students.Add(1, "Sagar");
students.Add(2, "Rahul");
students.Add(3, "Amit");

// Read by key
Console.WriteLine(students[1]); // Sagar

// Update existing value
students[2] = "Rohit";

// Remove by key
students.Remove(3);

// Check key
Console.WriteLine(students.ContainsKey(1)); // True

// Check value
Console.WriteLine(students.ContainsValue("Sagar")); // True

// Safe lookup
if (students.TryGetValue(2, out string? name))
{
    Console.WriteLine(name); // Rohit
}

// Clear
students.Clear();


Important methods:
Method	Purpose
Add(key, value)	Add a new key-value pair
Remove(key)	Remove by key
ContainsKey()	Check whether a key exists
ContainsValue()	Check whether a value exists
TryGetValue()	Safely retrieve a value
Clear()	Remove all pairs
Important: students.Add(1, "New Name") throws an exception if key 1 already exists. Use students[1] = "New Name" to add or update a value.
7. LinkedList — Add and remove nodes
LinkedList<int> list = new LinkedList<int>();

// Add
list.AddFirst(10);
list.AddLast(20);
list.AddLast(30);

// Add before a node
LinkedListNode<int>? node = list.Find(20);

if (node != null)
{
    list.AddBefore(node, 15);
}

// Remove
list.Remove(20);
list.RemoveFirst();
list.RemoveLast();

// Output
foreach (int item in list)
{
    Console.WriteLine(item);
}


Important methods:
- AddFirst() — add at the beginning.
- AddLast() — add at the end.
- AddBefore() — add before a node.
- AddAfter() — add after a node.
- Remove() — remove a value or node.
- RemoveFirst() — remove the first node.
- RemoveLast() — remove the last node.
- Find() — find a node containing a value.
8. PriorityQueue — Add and remove by priority
A PriorityQueue<TElement, TPriority> removes the element with the lowest priority value first by default.
PriorityQueue<string, int> queue =
    new PriorityQueue<string, int>();

// Add element, priority
queue.Enqueue("Low", 3);
queue.Enqueue("High", 1);
queue.Enqueue("Medium", 2);

// Read next element
Console.WriteLine(queue.Peek()); // High

// Remove next element
Console.WriteLine(queue.Dequeue()); // High


Important methods:
- Enqueue(element, priority) — add an element.
- Dequeue() — remove the element with the lowest priority value.
- Peek() — read the next element without removing it.
- Clear() — remove all elements.
9. Other useful collections
Collection	Add	Remove
SortedSet<T>	Add()	Remove()
SortedDictionary<K,V>	Add()	Remove(key)
ObservableCollection<T>	Add()	Remove()
ConcurrentQueue<T>	Enqueue()	TryDequeue()
ConcurrentStack<T>	Push()	TryPop()
ConcurrentDictionary<K,V>	TryAdd()	TryRemove()
These are useful for sorted data, UI data binding, and thread-safe operations.
10. Quick interview revision
1. Which collection follows FIFO?
Show answer

2. Which collection follows LIFO?
Show answer

3. Which collection stores unique values?
Show answer

4. Which collection stores key-value pairs?
Show answer

5. How do you remove an element from a List by index?
Show answer

Remember these five for your .NET interview:
- Queue → Enqueue() / Dequeue()
- Stack → Push() / Pop()
- List → Add() / Remove() / RemoveAt()
- HashSet → Add() / Remove()
- Dictionary → Add(key, value) / Remove(key)

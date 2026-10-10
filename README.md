# C# Collections — Add, Remove & Important Methods

A practical, interview-ready guide to commonly used C# collections, including their methods, code examples, and important interview questions.

## Table of Contents

1. [Collection Methods at a Glance](#1-collection-methods-at-a-glance)
2. [Queue — FIFO](#2-queue--fifo)
3. [Stack — LIFO](#3-stack--lifo)
4. [List — Ordered Collection](#4-list--ordered-collection)
5. [HashSet — Unique Elements](#5-hashset--unique-elements)
6. [Dictionary — Key-Value Pairs](#6-dictionary--key-value-pairs)
7. [LinkedList — Node-Based Collection](#7-linkedlist--node-based-collection)
8. [PriorityQueue — Priority-Based Collection](#8-priorityqueue--priority-based-collection)
9. [Other Useful Collections](#9-other-useful-collections)
10. [Quick Interview Questions](#10-quick-interview-questions)

---

## 1. Collection Methods at a Glance

| Collection | Add | Remove | Read / Search |
|---|---|---|---|
| `Queue<T>` | `Enqueue()` | `Dequeue()` | `Peek()` |
| `Stack<T>` | `Push()` | `Pop()` | `Peek()` |
| `List<T>` | `Add()` | `Remove()` | `Find()`, `Contains()` |
| `HashSet<T>` | `Add()` | `Remove()` | `Contains()` |
| `Dictionary<K,V>` | `Add()` | `Remove()` | `TryGetValue()` |
| `LinkedList<T>` | `AddFirst()`, `AddLast()` | `Remove()` | `Find()` |
| `SortedSet<T>` | `Add()` | `Remove()` | `Contains()` |
| `SortedDictionary<K,V>` | `Add()` | `Remove()` | `TryGetValue()` |
| `PriorityQueue<T,P>` | `Enqueue()` | `Dequeue()` | `Peek()` |
| `ConcurrentQueue<T>` | `Enqueue()` | `TryDequeue()` | `TryPeek()` |
| `ConcurrentStack<T>` | `Push()` | `TryPop()` | `TryPeek()` |
| `ConcurrentDictionary<K,V>` | `TryAdd()` | `TryRemove()` | `TryGetValue()` |

## 2. Queue — FIFO

**FIFO stands for First In, First Out.**

The first element added to a queue is the first element removed.

### Example

```csharp
Queue<int> queue = new Queue<int>();

// Add elements
queue.Enqueue(10);
queue.Enqueue(20);
queue.Enqueue(30);

// Read the first element
Console.WriteLine(queue.Peek()); // 10

// Remove the first element
Console.WriteLine(queue.Dequeue()); // 10

// Search for an element
Console.WriteLine(queue.Contains(20)); // True

// Get the number of elements
Console.WriteLine(queue.Count); // 2

// Remove all elements
queue.Clear();
```

### Important Methods

| Method | Description |
|---|---|
| `Enqueue()` | Adds an element to the end |
| `Dequeue()` | Removes and returns the first element |
| `Peek()` | Returns the first element without removing it |
| `Contains()` | Checks whether an element exists |
| `Clear()` | Removes all elements |
| `Count` | Returns the number of elements |

**Real-world example:** A queue of customers waiting at a counter.

## 3. Stack — LIFO

**LIFO stands for Last In, First Out.**

The last element added to a stack is the first element removed.

### Example

```csharp
Stack<int> stack = new Stack<int>();

// Add elements
stack.Push(10);
stack.Push(20);
stack.Push(30);

// Read the top element
Console.WriteLine(stack.Peek()); // 30

// Remove the top element
Console.WriteLine(stack.Pop()); // 30

// Search for an element
Console.WriteLine(stack.Contains(10)); // True

// Get the number of elements
Console.WriteLine(stack.Count); // 2

// Remove all elements
stack.Clear();
```

### Important Methods

| Method | Description |
|---|---|
| `Push()` | Adds an element to the top |
| `Pop()` | Removes and returns the top element |
| `Peek()` | Returns the top element without removing it |
| `Contains()` | Checks whether an element exists |
| `Clear()` | Removes all elements |
| `Count` | Returns the number of elements |

**Real-world example:** Undo operations, browser history, and function call stacks.

## 4. List — Ordered Collection

`List<T>` stores elements in an ordered collection and supports index-based access.

### Example

```csharp
List<int> numbers = new List<int>();

// Add elements
numbers.Add(10);
numbers.Add(20);
numbers.Add(30);

// Add an element at a specific index
numbers.Insert(1, 15);

// List: 10, 15, 20, 30

// Remove by value
numbers.Remove(20);

// Remove by index
numbers.RemoveAt(0);

// Access an element by index
Console.WriteLine(numbers[0]); // 15

// Search for an element
Console.WriteLine(numbers.Contains(30)); // True

// Find the first matching element
int result = numbers.Find(x => x > 20);
Console.WriteLine(result); // 30

// Sort the list
numbers.Sort();

// Remove all elements
numbers.Clear();
```

### Important Methods

| Method | Description |
|---|---|
| `Add()` | Adds one element |
| `AddRange()` | Adds multiple elements |
| `Insert()` | Inserts an element at a specific index |
| `Remove()` | Removes the first matching value |
| `RemoveAt()` | Removes an element by index |
| `RemoveAll()` | Removes elements matching a condition |
| `Contains()` | Checks whether a value exists |
| `Find()` | Finds the first matching element |
| `Sort()` | Sorts the list |
| `Clear()` | Removes all elements |
| `Count` | Returns the number of elements |

**Remember:** List indexes start at `0`.

## 5. HashSet — Unique Elements

`HashSet<T>` stores unique elements. Duplicate values are not added.

### Example

```csharp
HashSet<int> numbers = new HashSet<int>();

// Add elements
numbers.Add(10);
numbers.Add(20);
numbers.Add(30);

bool added = numbers.Add(20);

Console.WriteLine(added); // False

// Remove an element
numbers.Remove(10);

// Search for an element
Console.WriteLine(numbers.Contains(20)); // True

// Get the number of unique elements
Console.WriteLine(numbers.Count); // 2

// Remove all elements
numbers.Clear();
```

### Important Methods

| Method | Description |
|---|---|
| `Add()` | Adds a unique element; returns `false` for a duplicate |
| `Remove()` | Removes an element |
| `Contains()` | Checks whether an element exists |
| `UnionWith()` | Combines elements from another collection |
| `IntersectWith()` | Keeps only common elements |
| `ExceptWith()` | Removes elements found in another collection |
| `Clear()` | Removes all elements |

**Real-world example:** Removing duplicate values from a list of IDs.

## 6. Dictionary — Key-Value Pairs

`Dictionary<TKey, TValue>` stores data as key-value pairs. Every key must be unique, but values can be duplicated.

### Example

```csharp
Dictionary<int, string> students =
    new Dictionary<int, string>();

// Add key-value pairs
students.Add(1, "Sagar");
students.Add(2, "Rahul");
students.Add(3, "Amit");

// Read a value using its key
Console.WriteLine(students[1]); // Sagar

// Update an existing value
students[2] = "Rohit";

// Remove by key
students.Remove(3);

// Check whether a key exists
Console.WriteLine(students.ContainsKey(1)); // True

// Check whether a value exists
Console.WriteLine(students.ContainsValue("Sagar")); // True

// Safely retrieve a value
if (students.TryGetValue(2, out string? name))
{
    Console.WriteLine(name); // Rohit
}

// Remove all key-value pairs
students.Clear();
```

### Important Methods

| Method | Description |
|---|---|
| `Add(key, value)` | Adds a new key-value pair |
| `Remove(key)` | Removes a pair by key |
| `ContainsKey()` | Checks whether a key exists |
| `ContainsValue()` | Checks whether a value exists |
| `TryGetValue()` | Safely retrieves a value |
| `Clear()` | Removes all pairs |
| `Count` | Returns the number of pairs |

**Important interview point:**

```csharp
students.Add(1, "New Name"); // Throws if key 1 already exists

students[1] = "New Name";    // Adds or updates the value
```

Use `TryGetValue()` when you want to check for a key and retrieve its value safely.

## 7. LinkedList — Node-Based Collection

`LinkedList<T>` stores elements as nodes. Each node points to the previous and next nodes in a doubly linked list.

### Example

```csharp
LinkedList<int> list = new LinkedList<int>();

// Add elements
list.AddFirst(10);
list.AddLast(20);
list.AddLast(30);

// Find a node
LinkedListNode<int>? node = list.Find(20);

// Add before an existing node
if (node != null)
{
    list.AddBefore(node, 15);
}

// Add after an existing node
if (node != null)
{
    list.AddAfter(node, 25);
}

// Remove a value
list.Remove(20);

// Remove the first node
list.RemoveFirst();

// Remove the last node
list.RemoveLast();

// Display elements
foreach (int item in list)
{
    Console.WriteLine(item);
}
```

### Important Methods

| Method | Description |
|---|---|
| `AddFirst()` | Adds a node at the beginning |
| `AddLast()` | Adds a node at the end |
| `AddBefore()` | Adds a node before another node |
| `AddAfter()` | Adds a node after another node |
| `Remove()` | Removes a value or node |
| `RemoveFirst()` | Removes the first node |
| `RemoveLast()` | Removes the last node |
| `Find()` | Finds a node containing a value |
| `Clear()` | Removes all nodes |

**Remember:** A `LinkedList<T>` does not support direct index access like `list[0]`.

## 8. PriorityQueue — Priority-Based Collection

`PriorityQueue<TElement, TPriority>` removes elements according to their priority. By default, the element with the **lowest priority value** is removed first.

### Example

```csharp
PriorityQueue<string, int> queue =
    new PriorityQueue<string, int>();

// Add elements with priorities
queue.Enqueue("Low", 3);
queue.Enqueue("High", 1);
queue.Enqueue("Medium", 2);

// Read the next element
Console.WriteLine(queue.Peek()); // High

// Remove the next element
Console.WriteLine(queue.Dequeue()); // High

// Get the number of elements
Console.WriteLine(queue.Count); // 2
```

### Important Methods

| Method | Description |
|---|---|
| `Enqueue(element, priority)` | Adds an element with a priority |
| `Dequeue()` | Removes and returns the element with the lowest priority value |
| `Peek()` | Reads the next element without removing it |
| `Clear()` | Removes all elements |
| `Count` | Returns the number of elements |

**Note:** `PriorityQueue<TElement, TPriority>` is available in modern .NET versions, including .NET 6 and later.

## 9. Other Useful Collections

| Collection | Purpose |
|---|---|
| `SortedSet<T>` | Stores unique elements in sorted order |
| `SortedDictionary<K,V>` | Stores key-value pairs sorted by key |
| `ObservableCollection<T>` | Notifies listeners when items change; useful for UI data binding |
| `ConcurrentQueue<T>` | Thread-safe FIFO queue |
| `ConcurrentStack<T>` | Thread-safe LIFO stack |
| `ConcurrentDictionary<K,V>` | Thread-safe key-value collection |

### Example: ConcurrentQueue

```csharp
using System.Collections.Concurrent;

ConcurrentQueue<int> queue = new ConcurrentQueue<int>();

queue.Enqueue(10);
queue.Enqueue(20);

if (queue.TryDequeue(out int value))
{
    Console.WriteLine(value); // 10
}
```

**Note:** Concurrent collections provide thread-safe operations, but thread safety does not automatically make a sequence of multiple operations atomic.

## 10. Quick Interview Questions

### Q1. Which collection follows FIFO?

**Answer:** `Queue<T>` — First In, First Out.

### Q2. Which collection follows LIFO?

**Answer:** `Stack<T>` — Last In, First Out.

### Q3. Which collection stores unique values?

**Answer:** `HashSet<T>`.

### Q4. Which collection stores key-value pairs?

**Answer:** `Dictionary<TKey, TValue>`.

### Q5. How do you remove an element from a List by index?

**Answer:**

```csharp
List<int> numbers = new List<int> { 10, 20, 30 };

numbers.RemoveAt(1);

// Result: 10, 30
```

### Q6. What is the difference between `Remove()` and `RemoveAt()`?

**Answer:**
- `Remove(value)` removes the first matching value.
- `RemoveAt(index)` removes the element at a specified index.

### Q7. What is the difference between `Peek()` and `Pop()`?

**Answer:**
- `Peek()` reads the top element without removing it.
- `Pop()` removes and returns the top element.

### Q8. What is the difference between `Add()` and `TryAdd()`?

**Answer:**
- `Dictionary.Add()` throws an exception if the key already exists.
- `ConcurrentDictionary.TryAdd()` returns `false` if the key already exists.

### Q9. How do you prevent duplicate elements?

**Answer:** Use `HashSet<T>`.

### Q10. Which collection should you use for frequent index-based access?

**Answer:** `List<T>`.

---

## Quick Revision

| Collection | Add | Remove | Read |
|---|---|---|---|
| Queue | `Enqueue()` | `Dequeue()` | `Peek()` |
| Stack | `Push()` | `Pop()` | `Peek()` |
| List | `Add()` | `Remove()` / `RemoveAt()` | Index / `Find()` |
| HashSet | `Add()` | `Remove()` | `Contains()` |
| Dictionary | `Add()` / indexer | `Remove()` | `TryGetValue()` |
| LinkedList | `AddFirst()` / `AddLast()` | `Remove()` | `Find()` |
| PriorityQueue | `Enqueue()` | `Dequeue()` | `Peek()` |

### Key Takeaways

- **Queue:** FIFO — `Enqueue()` and `Dequeue()`.
- **Stack:** LIFO — `Push()` and `Pop()`.
- **List:** Ordered, index-based access.
- **HashSet:** Unique elements.
- **Dictionary:** Unique keys with associated values.
- **LinkedList:** Node-based collection.
- **PriorityQueue:** Elements are removed according to priority.

These collections and their methods are important for C# coding rounds, data structure problems, and .NET developer interviews.

Sets in C#


Welcome to the Sets tutorial! A Set is a collection that contains unique elements. Sets are widely used in programming when you need to store unordered data and ensure there are no duplicate values.

In C#, sets are implemented using the HashSet<T> class in the System.Collections.Generic namespace.


Why Use Sets?
Fast Lookups: Checking for an element’s existence in a set is very efficient, typically O(1) time complexity.
Automatic Uniqueness: Sets only allow unique elements, so duplicates are automatically ignored.
Unordered Collection: Sets don’t maintain the order of elements, which saves memory and processing time compared to ordered collections.
Creating a Set
To create a set, use the HashSet<T> class:

Example:

```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        HashSet<int> numbers = new HashSet<int>();

        // Adding elements
        numbers.Add(1);
        numbers.Add(2);
        numbers.Add(3);
        numbers.Add(2); // Duplicate - will be ignored

        Console.WriteLine("Set Elements:");
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
```
Output:
Set Elements:
1
2
3
Notice how the duplicate 2 is ignored. Sets automatically handle duplicates for you.

Common Set Operations
Here are the most common operations you can perform with sets in C#:

1. Adding Elements
Use the .Add() method to add elements to a set.
If the element already exists, the set ignores it.

```csharp
HashSet<string> fruits = new HashSet<string>();
fruits.Add("Apple");
fruits.Add("Banana");
fruits.Add("Apple"); // Duplicate ignored

Console.WriteLine($"Set contains {fruits.Count} unique fruits.");
```
2. Removing Elements
Use the .Remove() method to remove elements from a set.
```csharp
HashSet<int> numbers = new HashSet<int> { 1, 2, 3, 4 };
numbers.Remove(3);

Console.WriteLine("After removing 3:");
foreach (var num in numbers)
    Console.WriteLine(num);
```
Output:

After removing 3:
1
2
4

3. Checking for Existence
Use the .Contains() method to check if an element exists in the set.
```csharp
HashSet<int> numbers = new HashSet<int> { 1, 2, 3, 4 };

if (numbers.Contains(2))
    Console.WriteLine("2 exists in the set.");
else
    Console.WriteLine("2 does not exist in the set.");
```

4. Clearing a Set
Use the .Clear() method to remove all elements from the set.
```csharp
HashSet<int> numbers = new HashSet<int> { 1, 2, 3 };
numbers.Clear();

Console.WriteLine($"Set count after clearing: {numbers.Count}");
```


5. Set Operations: Union, Intersection, Difference
Sets are very useful for operations such as union, intersection, and difference. These operations are performed using built-in methods in the HashSet class.

a. Union
The union of two sets combines all unique elements from both sets.
```csharp
HashSet<int> setA = new HashSet<int> { 1, 2, 3 };
HashSet<int> setB = new HashSet<int> { 3, 4, 5 };

setA.UnionWith(setB);

Console.WriteLine("Union of SetA and SetB:");
foreach (var item in setA)
    Console.WriteLine(item);
```

Output:
Union of SetA and SetB:
1
2
3
4
5

b. Intersection
The intersection of two sets includes only the elements common to both sets.
```csharp
HashSet<int> setA = new HashSet<int> { 1, 2, 3 };
HashSet<int> setB = new HashSet<int> { 2, 3, 4 };

setA.IntersectWith(setB);

Console.WriteLine("Intersection of SetA and SetB:");
foreach (var item in setA)
    Console.WriteLine(item);
```

Output:
Intersection of SetA and SetB:
2
3


c. Difference
The difference between two sets includes only the elements that exist in one set but not the other.
```csharp
HashSet<int> setA = new HashSet<int> { 1, 2, 3 };
HashSet<int> setB = new HashSet<int> { 2, 3, 4 };

setA.ExceptWith(setB);

Console.WriteLine("Difference of SetA and SetB:");
foreach (var item in setA)
    Console.WriteLine(item);
```
Output:

Difference of SetA and SetB:
1

Example Problem: Find the Intersection of Two Arrays
Write a program that finds the common elements (intersection) between two arrays.

Solution

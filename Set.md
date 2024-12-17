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

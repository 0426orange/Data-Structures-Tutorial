
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] array1 = { 1, 2, 3, 4, 5 };
        int[] array2 = { 3, 4, 5, 6, 7 };

        HashSet<int> set1 = new HashSet<int>(array1);
        HashSet<int> set2 = new HashSet<int>(array2);

        set1.IntersectWith(set2);

        Console.WriteLine("Common Elements:");
        foreach (var num in set1)
            Console.WriteLine(num);
    }
}

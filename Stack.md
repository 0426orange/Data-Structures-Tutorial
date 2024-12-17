# Stack  

Software would be very limited if we didn’t have a way to organize and control data based on its order. Imagine you had a to-do list app, but it always processed tasks in a completely random order:  

- You wouldn’t be able to complete the most recent task first.  
- You wouldn’t be able to undo the most recent changes in a drawing app.  
- You wouldn’t be able to navigate backward in your web browser history.  

In reality, many applications use a **Stack** to solve these problems because it allows us to access data in **Last In, First Out (LIFO)** order.  

---

## How a Stack Works  

A **Stack** allows you to add and remove data in a controlled way. It follows the **LIFO** principle: the last item added is the first one removed.  

### Operations  
Here are the common operations for a stack:  

1. **Push**: Add an item to the top of the stack.  
2. **Pop**: Remove the top item from the stack.  
3. **Peek**: View the top item without removing it.  
4. **IsEmpty**: Check if the stack has no items.  

### Example: Undo Feature  
Imagine you’re writing code in a text editor and make changes:  

1. Add a function — Push "Function 1" onto the stack.  
2. Add a loop — Push "Loop" onto the stack.  
3. Add a variable — Push "Variable" onto the stack.  

When you press **Undo**, the most recent change is undone (Pop "Variable" off the stack). You keep undoing changes in reverse order until you reach the first one.  

---

## How to Use a Stack in C#  

Here’s an example of implementing a stack in C#:  

```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<string> history = new Stack<string>();

        // Push items onto the stack
        history.Push("Function 1");
        history.Push("Loop");
        history.Push("Variable");

        // Peek at the top item
        Console.WriteLine("Last change: " + history.Peek());

        // Undo changes using Pop
        Console.WriteLine("Undoing: " + history.Pop());
        Console.WriteLine("Undoing: " + history.Pop());

        // Check if the stack is empty
        if (history.Count == 0)
        {
            Console.WriteLine("No changes to undo!");
        }
        else
        {
            Console.WriteLine("Last remaining change: " + history.Peek());
        }
    }
}
Output:
Last change: Variable  
Undoing: Variable  
Undoing: Loop  
Last remaining change: Function 1  

Efficiency of Common Operations
Stacks are efficient because all operations happen at the top of the stack.

Operation 	Time Complexity
Push      	O(1)
Pop        	O(1)
Peek      	O(1)
IsEmpty	    O(1)
Example Problem: Browser History
You’re building a web browser that needs to support the Back and Forward buttons. Use a stack to simulate the following scenario:

Open Page A.
Open Page B.
Open Page C.
Press Back twice.
What pages are left on the stack, and what’s the current page?

Hint: Use two stacks: one for back history and one for forward history.

Problem to Solve: Reversing Words
Write a program to reverse the words in a sentence using a stack.

Example:
Input: "I love programming"
Output: "programming love I"

Hint: Push each word onto the stack and pop them back out in reverse order.

solution

This tutorial covered:

How a stack works.
Real-life examples of stacks.
Efficiency of operations.
Example problems and practice scenarios.
Now you should understand how to use stacks effectively! Try solving the practice problem on your own before looking at the solution.

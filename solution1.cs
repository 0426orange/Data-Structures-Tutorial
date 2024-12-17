// Example: Solution Template  
Stack<string> words = new Stack<string>();

// Split sentence into words and Push each onto the stack
string[] sentence = "I love programming".Split(' ');
foreach (var word in sentence)
{
    words.Push(word);
}

// Pop words to form the reversed sentence
while (words.Count > 0)
{
    Console.Write(words.Pop() + " ");
}

using System;
using System.Collections.Generic;

namespace Queue
{
    public class ReverseQueue
    {
        public static void Run()
        {
            Queue<int> queue = new Queue<int>(new[] { 10, 20, 30 });
            Console.WriteLine($"Original Queue: [{string.Join(", ", queue)}]");

            Stack<int> stack = new Stack<int>();

            while (queue.Count > 0)
            {
                stack.Push(queue.Dequeue());
            }

            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }

            Console.WriteLine($"Reversed Queue: [{string.Join(", ", queue)}]");
        }
    }
}

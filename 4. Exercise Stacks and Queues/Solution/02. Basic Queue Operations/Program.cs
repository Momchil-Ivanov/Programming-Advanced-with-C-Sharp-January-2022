using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            int[] commands = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int toAdd = commands[0];
            int toRemove = commands[1];
            int toLookFor = commands[2];
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < toAdd; i++)
            {
                queue.Enqueue(numbers[i]);
            }
            for (int i = 0; i < toRemove; i++)
            {
                queue.Dequeue();
            }
            if (queue.Contains(toLookFor))
            {
                Console.WriteLine($"true");
            }
            else if (!queue.Contains(toLookFor) && queue.Count > 0)
            {
                Console.WriteLine(queue.Min());
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}

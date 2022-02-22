using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            Queue<int> queue = new Queue<int>();
            int[] quantityOfOrder = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool failedToServed = false;

            foreach (var item in quantityOfOrder)
            {
                queue.Enqueue(item);    
            }

            Console.WriteLine(queue.Max());

            for (int i = 0; i < quantityOfOrder.Length; i++)
            {
                int currentClient = queue.Peek();
                if (quantity >= currentClient)
                {
                    quantity -= currentClient;
                    queue.Dequeue();
                }
                else
                {
                   failedToServed = true;   
                }
            }

            if (failedToServed)
            {
                Console.Write($"Orders left:");
                foreach (var leftItem in queue)
                {
                    Console.Write($" {leftItem}");
                }
            }
            else
            {
                Console.WriteLine($"Orders complete");
            }
        }
    }
}

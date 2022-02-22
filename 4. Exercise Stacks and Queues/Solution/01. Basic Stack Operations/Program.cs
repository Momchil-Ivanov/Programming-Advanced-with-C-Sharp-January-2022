using System;
using System.Collections.Generic;

namespace Exercise_Stacks_and_Queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split(' ');
            int toPush = int.Parse(command[0]);
            int toPop = int.Parse(command[1]);
            int toLookFor = int.Parse(command[2]);

            string[] numbers = Console.ReadLine().Split(' ');
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < toPush; i++)
            {
                int number = int.Parse(numbers[i]);
                stack.Push(number);
            }

            for (int i = 0; i < toPop; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(toLookFor))
            {
                Console.WriteLine($"true");
            }
            else if (!stack.Contains(toLookFor) && stack.Count > 0)
            {
                int[] arr = stack.ToArray();
                int smallest = int.MaxValue;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (smallest > arr[i])
                    {
                        smallest = arr[i];
                    }
                }
                Console.WriteLine(smallest);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace Stacks_and_Queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringToReverse = Console.ReadLine();

            Stack<char> stack = new Stack<char>();

            foreach (var symbol in stringToReverse)
            {
                stack.Push(symbol);
            }

            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }
        }
    }
}

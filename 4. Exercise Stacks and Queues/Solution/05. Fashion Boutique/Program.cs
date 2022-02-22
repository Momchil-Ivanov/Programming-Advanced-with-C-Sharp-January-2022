using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rackCapacity = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>(clothes);
            int numberOfRacks = 0;
            int currentCapacity = 0;

            while (stack.Count > 0)
            {
                currentCapacity += stack.Peek();

                if (currentCapacity < rackCapacity)
                {
                    stack.Pop();
                }
                else if (currentCapacity == rackCapacity)
                {
                    stack.Pop();
                    numberOfRacks++;
                    currentCapacity = 0;
                }
                else
                {
                    numberOfRacks++;
                    currentCapacity = 0;
                }
            }

            if (currentCapacity > 0)
            {
                numberOfRacks++;
            }

            Console.WriteLine(numberOfRacks);
        }
    }
}

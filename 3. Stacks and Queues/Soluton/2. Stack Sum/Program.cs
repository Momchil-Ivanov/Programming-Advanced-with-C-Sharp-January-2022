using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(numbers);

            string command = Console.ReadLine().ToLower();

            while (command != "end")
            {
                var splitedCommand = command.Split();
                if (splitedCommand[0] == "add")
                {
                    int first = int.Parse(splitedCommand[1]);   
                    int second = int.Parse(splitedCommand[2]);

                    stack.Push(first);
                    stack.Push(second);
                }
                if (splitedCommand[0] == "remove")
                {
                    int count = int.Parse(splitedCommand[1]);
                    if (count <= stack.Count)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            stack.Pop();
                        }
                    }
                }
                command = Console.ReadLine().ToLower();
            }

            int sum = 0;
            while (stack.Count>0)
            {
                sum += stack.Pop();
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}

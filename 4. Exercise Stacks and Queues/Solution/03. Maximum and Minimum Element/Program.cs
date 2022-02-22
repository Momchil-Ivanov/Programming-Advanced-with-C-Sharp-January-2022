using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();    

            for (int i = 0; i < numberOfCommands; i++)
            {
                int[] currentCommand = Console.ReadLine().Split (' ').Select(int.Parse).ToArray();

                if (currentCommand.Length == 2)
                {
                    stack.Push(currentCommand[1]);   
                }
                else
                {
                    if (currentCommand[0] == 2)
                    {
                        if (stack.Count > 0)
                        {
                            stack.Pop();
                        }
                    }
                    else if (currentCommand[0] == 3)
                    {
                        int maxNumber = int.MinValue;

                        if (stack.Count > 0)
                        {
                            foreach (var item in stack)
                            {
                                if (item > maxNumber)
                                {
                                    maxNumber = item;
                                }
                            }
                            Console.WriteLine(maxNumber);
                        }                     
                    }
                    else if (currentCommand[0] == 4)
                    {
                        int minNumber = int.MaxValue;

                        if (stack.Count > 0)
                        {
                            foreach (var item in stack)
                            {
                                if (item < minNumber)
                                {
                                    minNumber = item;
                                }
                            }
                            Console.WriteLine(minNumber);
                        }
                    }
                }
            }

            Console.WriteLine(String.Join(", ", stack));
        }
    }
}

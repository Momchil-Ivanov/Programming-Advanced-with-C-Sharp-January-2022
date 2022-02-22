using System;
using System.Collections.Generic;

namespace _3._Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();  
            string[] command = Console.ReadLine().Split(' ');

            int sum = 0;
            int currentNumber = 0;

            foreach (var item in command)
            {
                stack.Push(item);   
            }

            while (stack.Count > 1)
            {
                string element = stack.Pop();

                if (element == "+")
                {
                    sum += currentNumber;
                }
                else if (element == "-")
                {
                    sum -= currentNumber;
                }
                else
                {
                    currentNumber = int.Parse(element);
                }
              
            }

            currentNumber = int.Parse(stack.Pop());
            sum += currentNumber;

            Console.WriteLine(sum);
        }
    }
}

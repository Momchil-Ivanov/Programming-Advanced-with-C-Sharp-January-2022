﻿using System;
using System.Collections.Generic;

namespace _7._Hot_Potato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] people = Console.ReadLine().Split();
            Queue<string> queue = new Queue<string>(people);
            int tossCountToRemove = int.Parse(Console.ReadLine());
            int currentTosses = 1;

            while (queue.Count > 1)
            {
                var kidWithPotato = queue.Dequeue();
                if (currentTosses != tossCountToRemove)
                {
                    queue.Enqueue(kidWithPotato);
                    currentTosses++;
                }
                else
                {
                    Console.WriteLine($"Removed {kidWithPotato}");
                    currentTosses = 1;
                }
            }

            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}

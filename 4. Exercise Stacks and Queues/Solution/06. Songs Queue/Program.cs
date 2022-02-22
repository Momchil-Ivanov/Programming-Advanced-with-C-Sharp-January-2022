using System;
using System.Collections.Generic;

namespace _06._Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] songList = Console.ReadLine().Split(", ");
            Queue<string> queue = new Queue<string>(songList);
            string songToAdd = string.Empty;

            while (queue.Count > 0)
            {
                string[] command = Console.ReadLine().Split(" ");

                if (command[0] == "Play")
                {
                    queue.Dequeue();
                }

                else if (command[0] == "Show")
                {
                    Console.WriteLine(String.Join(", ", queue));
                }

                else if (command[0] == "Add")
                {
                    for (int i = 1; i < command.Length; i++)
                    {
                        songToAdd += command[i];
                        songToAdd += new String(' ', 1);    
                    }

                    songToAdd = songToAdd.TrimEnd();

                    if (!queue.Contains(songToAdd))
                    {
                        queue.Enqueue(songToAdd);
                    }
                    else
                    {
                        Console.WriteLine($"{songToAdd} is already contained!");
                    }

                     songToAdd = string.Empty;
                }
            }

            Console.WriteLine($"No more songs!");
        }
    }
}

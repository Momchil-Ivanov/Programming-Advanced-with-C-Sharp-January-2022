using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Periodic_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            SortedSet<string> elements = new SortedSet<string>();
            FillSet(elements, lines);
            Console.WriteLine(string.Join(" ", elements));
        }

        private static SortedSet<string> FillSet(SortedSet<string> elements, int lines)
        {
            for (int i = 0; i < lines; i++)
            {
                List<string> compunds = Console.ReadLine().Split().ToList();
                compunds.ForEach(compund => elements.Add(compund));
            }

            return elements;
        }
    }
}
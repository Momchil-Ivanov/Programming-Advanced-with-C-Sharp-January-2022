using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._Key_Revolver__not_included_in_final_score_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int gunBarrel = int.Parse(Console.ReadLine());

            int[] inputBullets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] inputLocks = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int intelligence = int.Parse(Console.ReadLine());

            Stack<int> bullets = new Stack<int>(inputBullets);
            Queue<int> locks = new Queue<int>(inputLocks);

            int currentShots = gunBarrel;
            int bulletsCount = 0;

            while (bullets.Count > 0 && locks.Count > 0)
            {
                int bullet = bullets.Pop();

                int currentLock = locks.Peek();

                currentShots--;
                bulletsCount++;

                if (bullet <= currentLock)
                {
                    Console.WriteLine($"Bang!");
                    locks.Dequeue();

                }
                else
                {
                    Console.WriteLine($"Ping!");
                }

                if (currentShots == 0 && bullets.Count > 0)
                {
                    Console.WriteLine($"Reloading!");
                    currentShots = gunBarrel;
                }
            }

            if (locks.Count == 0)
            {
                int result = intelligence - (bulletsCount * bulletPrice);
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${result}");
            }
            else
            {             
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");  
            }

        }
    }
}

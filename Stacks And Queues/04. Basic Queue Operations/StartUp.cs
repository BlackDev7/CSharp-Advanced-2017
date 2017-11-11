using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Basic_Queue_Operations
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var tokens = Console.ReadLine().Split();
            var cycleCount = tokens[0];
            var numbers = Console.ReadLine().Split().Select(int.Parse);
            var queueInts = new Queue<int>(numbers);
            var popCount = int.Parse(tokens[1]);

            for (int i = 0; i < popCount; i++)
            {
                queueInts.Dequeue();
            }

            var numberToCheck = int.Parse(tokens[2]);
            if (queueInts.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                if (queueInts.Contains(numberToCheck))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(queueInts.Min());
                }
            }
        }
    }
}

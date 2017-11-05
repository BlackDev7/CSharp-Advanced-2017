using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Hot_Potato
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var inputNames = Console.ReadLine().Split();
            var nNumber = int.Parse(Console.ReadLine());
            var queue = new Queue<string>(inputNames);

            while (queue.Count != 1)
            {
                for (int i = 1; i < nNumber; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }
                Console.WriteLine($"Removed {queue.Dequeue()}");
            }
            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}

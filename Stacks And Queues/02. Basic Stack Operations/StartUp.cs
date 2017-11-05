using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _02.Basic_Stack_Operations
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var elementsToPush = input[0];
            var elementsToPop = input[1];
            var checkIfPresent = input[2];
            var stack = new Stack<int>();

            var numbersInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < elementsToPush; i++)
            {
                stack.Push(numbersInput[i]);
            }
            for (int i = 0; i < elementsToPop; i++)
            {
                stack.Pop();
            }
            if (stack.Contains(checkIfPresent))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (stack.Count == 0)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    Console.WriteLine(stack.Min());

                }
            }
        }
    }
}

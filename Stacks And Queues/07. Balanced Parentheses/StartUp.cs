using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _07.Balanced_Parentheses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            int firstHalfIndex = input.Length / 2;
            var firstPartStack = new Stack<char>(input.Take(firstHalfIndex).ToArray());
            var secondPartQueue = new Queue<char>(input.Skip(firstHalfIndex));
            var isParentful = false;
            for (int i = 0; i < firstHalfIndex; i++)
            {
                isParentful = IsParentfull(firstPartStack, secondPartQueue);
                if (!isParentful)
                {
                    break;
                }
            }
            Console.WriteLine(isParentful ? "YES" : "NO");
        }

        private static bool IsParentfull(Stack<char> firstPartStack, Queue<char> secondPartQueue)
        {
            var openBracked = firstPartStack.Pop();
            var closingBracked = secondPartQueue.Dequeue();
            switch (openBracked)
            {
                case '(':
                    if (closingBracked != ')')
                    {
                        return false;
                    }
                    break;
                case '[':
                    if (closingBracked != ']')
                    {
                        return false;
                    }
                    break;
                case '{':
                    if (closingBracked != '}')
                    {
                        return false;
                    }
                    break;
                case ')':
                    if (closingBracked != '(')
                    {
                        return false;
                    }
                    break;
            }
            return true;
        }
    }
}

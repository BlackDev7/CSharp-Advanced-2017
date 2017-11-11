using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09a.Stack_Fibonacci
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var stack = new Stack<long>();
            stack.Push(0L);
            stack.Push(1L);

            for (int i = 1; i < n; i++)
            {
                var numberOne = stack.Pop();
                var numberTwo = stack.Pop();
                stack.Push(numberOne);
                stack.Push(numberTwo + numberOne);
            }
            Console.WriteLine(stack.Peek());
        }
    }
}

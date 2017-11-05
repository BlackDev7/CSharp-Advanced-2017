using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Simple_Calculator
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            
            string[] input = Console.ReadLine().Split("\t\n\r ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Reverse().ToArray();
            Stack<int> numbersStack = new Stack<int>();
            Stack<string> operatorsStack = new Stack<string>();

            foreach (var str in input)
            {
                if(str == "-" || str == "+")
                {
                    operatorsStack.Push(str);
                }
                else
                {
                    numbersStack.Push(int.Parse(str));
                }
            }

            int result = Calculate(numbersStack, operatorsStack);
            Console.WriteLine(result);
            
        }

        private static int Calculate(Stack<int> numbersStack, Stack<string> operatorsStack)
        {
            int result = numbersStack.Pop();

            while (numbersStack.Count != 0)
            {
                var currentNumber = numbersStack.Pop();
                var currentOperator = operatorsStack.Pop();
                if (currentOperator == "+")
                {
                    result += currentNumber;
                }
                else
                {
                    result -= currentNumber;
                }
            }
            return result;
        }
    }
}

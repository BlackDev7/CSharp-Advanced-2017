﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Decimal_to_Binary_Converter
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();
            if (number == 0)
            {
                Console.WriteLine(0);
            }
            while (number != 0)
            {
                stack.Push(number % 2);
                number /= 2;
            }
            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }
        }
    }
}

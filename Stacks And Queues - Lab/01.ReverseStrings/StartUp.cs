﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ReverseStrings
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var stack = new Stack<char>();

            foreach (var ch in input)
            {
                stack.Push(ch);
            }

            while(stack.Count != 0)
            {
                Console.Write(stack.Pop());               
            }

        }
    }
}

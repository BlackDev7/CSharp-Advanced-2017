using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Maximum_Element
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var numberOfInputs = int.Parse(Console.ReadLine());
            var hashset = new HashSet<int>();
            for (int i = 0; i < numberOfInputs; i++)
            {
                var tokens = Console.ReadLine().Split();
                var command = int.Parse(tokens[0]);
                switch (command)
                {
                    case 1:
                    {
                        if (tokens.Length > 1)
                        {
                            hashset.Add(int.Parse(tokens[1]));
                        }
                        break;
                    }
                    case 2:
                    {
                        hashset.Remove(hashset.Last());
                        break;
                    }
                    case 3:
                    {
                        Console.WriteLine(hashset.Max());
                        break;
                    }
                }
            }
        }
    }
}

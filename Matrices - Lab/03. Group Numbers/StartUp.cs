using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Group_Numbers
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(new[] {", "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);

            Console.WriteLine(string.Join(" ", numbers.Where(n => Math.Abs(n) % 3 == 0)));
            Console.WriteLine(string.Join(" ", numbers.Where(n => Math.Abs(n) % 3 == 1)));
            Console.WriteLine(string.Join(" ", numbers.Where(n => Math.Abs(n) % 3 == 2)));

        }
    }
}

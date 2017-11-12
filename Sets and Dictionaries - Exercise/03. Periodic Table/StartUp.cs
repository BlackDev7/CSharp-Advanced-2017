using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Periodic_Table
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var compoundsCount = int.Parse(Console.ReadLine());
            var uniqueCompounds = new SortedSet<string>();
            for (int i = 0; i < compoundsCount; i++)
            {
                ReadCompounds(uniqueCompounds);
            }

            PrintCompounds(uniqueCompounds);
;        }

        private static void PrintCompounds(SortedSet<string> uniqueCompounds)
        {
            Console.WriteLine(string.Join(" ", uniqueCompounds));
        }

        private static void ReadCompounds(SortedSet<string> uniqueCompounds)
        {
            var compounds = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            foreach (var compound in compounds)
            {
                uniqueCompounds.Add(compound);
            }
        }
    }
}

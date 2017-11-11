using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Count_Same_Values_in_Array
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(decimal.Parse).ToArray();
            var sortedDictionary = new SortedDictionary<decimal, int>();
            foreach (var value in input)
            {
                if (!sortedDictionary.ContainsKey(value))
                {
                    sortedDictionary[value] = 0;
                }
                sortedDictionary[value]++;
            }
            if (sortedDictionary.Count != 0)
            {
                foreach (var kvp in sortedDictionary)
                {
                    var value = kvp.Key;
                    var count = kvp.Value;
                    Console.WriteLine($"{value} - {count} times");
                }
            }
        }
    }
}

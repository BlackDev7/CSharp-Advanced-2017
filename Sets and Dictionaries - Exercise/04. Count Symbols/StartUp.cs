using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Count_Symbols
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var symbolsCount = new SortedDictionary<char, int>();

            foreach (var ch in input)
            {
                if (!symbolsCount.ContainsKey(ch))
                {
                    symbolsCount[ch] = 0;
                }
                symbolsCount[ch]++;
            }

            foreach (var symbol in symbolsCount)
            {
                Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Sets_of_Elements
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var setCounts = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var firstSet = new HashSet<int>();
            var secondSet = new HashSet<int>();
            var firstSetCount = setCounts[0];
            var secondSetCount = setCounts[1];

            for (int i = 0; i < firstSetCount; i++)
            {
                ReadElements("firstSet", firstSet, secondSet);
            }

            for (int i = 0; i < secondSetCount; i++)
            {
                ReadElements("secondSet", firstSet, secondSet);
            }

            PrintRepeatingElements(firstSet, secondSet);
        }

        private static void PrintRepeatingElements(HashSet<int> firstSet, HashSet<int> secondSet)
        {
            var elementString = "";
            foreach (var element in firstSet)
            {
                if (secondSet.Contains(element))
                {
                    elementString += element + " ";
                }
            }
            Console.WriteLine(elementString.TrimEnd());
        }

        private static void ReadElements(string firstOrSecondSet, HashSet<int> firstSet, HashSet<int> secondSet)
        {
            var currentElement = int.Parse(Console.ReadLine());
            if (firstOrSecondSet == "firstSet")
            {
                firstSet.Add(currentElement);
            }
            else
            {
                secondSet.Add(currentElement);
            }
        }
    }
}

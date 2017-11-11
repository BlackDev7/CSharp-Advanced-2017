using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Parking_Lot
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var tokens = Console.ReadLine().Split(',');
            var hashSet = new SortedSet<string>();
            while (tokens[0] != "END")
            {
                var command = tokens[0];
                var carNumber = tokens[1].TrimStart();

                if (command == "IN")
                {
                    hashSet.Add(carNumber);
                }
                else
                {
                    hashSet.Remove(carNumber);
                }

                tokens = Console.ReadLine().Split(',');
            }

            if (hashSet.Count != 0)
            {
                foreach (var car in hashSet)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}

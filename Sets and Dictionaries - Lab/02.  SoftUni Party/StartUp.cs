using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.SoftUni_Party
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var sortedVipSet = new SortedSet<string>();
            var sortedMemberSet = new SortedSet<string>();
            while (input != "PARTY")
            {
                ReadGuests(input, sortedMemberSet, sortedVipSet);
                input = Console.ReadLine();
            }
            while (input != "END")
            {
                RemoveGuests(input, sortedMemberSet, sortedVipSet);
                input = Console.ReadLine();
            }

            PrintGuests(sortedMemberSet, sortedVipSet);
        }

        private static void RemoveGuests(string input, SortedSet<string> sortedMemberSet, SortedSet<string> sortedVipSet)
        {
            var currentGuest = input;
            if (sortedVipSet.Contains(currentGuest))
            {
                sortedVipSet.Remove(currentGuest);
            }
            else if (sortedMemberSet.Contains(currentGuest))
            {
                sortedMemberSet.Remove(currentGuest);
            }
        }

        private static void ReadGuests(string input, SortedSet<string> sortedMemberSet, SortedSet<string> sortedVipSet)
        {
            var vipMatch = Regex.Match(input, @"\b[0-9][0-9a-zA-Z]{7}\b");
            var memberMatch = Regex.Match(input, @"\b[\D][0-9a-zA-Z]{7}\b");
            if (vipMatch.Success)
            {
                sortedVipSet.Add(vipMatch.Value);
            }
            else if (memberMatch.Success)
            {
                sortedMemberSet.Add(memberMatch.Value);
            }
        }

        private static void PrintGuests(SortedSet<string> sortedMemberSet, SortedSet<string> sortedVipSet)
        {
            Console.WriteLine(sortedVipSet.Count + sortedMemberSet.Count);
            if (sortedVipSet.Count != 0)
            {
                foreach (var vipGuest in sortedVipSet)
                {
                    Console.WriteLine(vipGuest);
                }
            }
            if (sortedMemberSet.Count != 0)
            {
                foreach (var guest in sortedMemberSet)
                {
                    Console.WriteLine(guest);
                }
            }
        }
    }
}

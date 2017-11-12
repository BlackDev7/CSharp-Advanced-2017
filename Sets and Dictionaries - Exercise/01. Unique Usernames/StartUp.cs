using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Unique_Usernames
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var inputCount = int.Parse(Console.ReadLine());
            var usernames = new HashSet<string>();
            for (int i = 0; i < inputCount; i++)
            {
                ReadUsernames(usernames);
            }
            PrintUsernames(usernames);
        }

        private static void PrintUsernames(HashSet<string> usernames)
        {
            foreach (var username in usernames)
            {
                Console.WriteLine(username);
            }
        }

        private static void ReadUsernames(HashSet<string> usernames)
        {
            var username = Console.ReadLine();
            usernames.Add(username);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Simple_Text_Editor
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var operationsCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < operationsCount; i++)
            {
                var tokens = Console.ReadLine().Split();
                var command = int.Parse(tokens[0]);
                switch (command)
                {
                    case 1:
                        var stringToAppeal = tokens[1];

                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                }
            }
        }
    }
}

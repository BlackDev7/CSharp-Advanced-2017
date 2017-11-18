using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Pascal_Triangle
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var rows = int.Parse(Console.ReadLine());

            long[][] pascalTriangle = new long[rows][];
            for (int i = 1; i < rows; i++) { pascalTriangle[i] = new long[i + 1]; }
            pascalTriangle[0] = new[] {0L};

            Console.WriteLine(1);
            for (var row = 1; row < rows; row++)
            {
                for (int col = 0; col <= row; col++)
                {
                    if (col == 0 || col == row)
                    {
                        pascalTriangle[row][col] = 1;
                    }
                    else
                    {
                        pascalTriangle[row][col] = pascalTriangle[row - 1][col - 1] + pascalTriangle[row - 1][col];
                    }   
                }

                Console.WriteLine(string.Join(" ", pascalTriangle[row]));
            }

        }
    }
}

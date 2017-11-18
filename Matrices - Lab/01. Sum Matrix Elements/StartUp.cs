using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sum_Matrix_Elements
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var matrixRowsCols = Console.ReadLine().Split(new[] {", "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            var matrix = new int[matrixRowsCols[0]][];
            var matrixSum = 0;

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
                matrixSum += matrix[i].Sum();
            }
            Console.WriteLine(matrixRowsCols[0]);
            Console.WriteLine(matrixRowsCols[1]);
            Console.WriteLine(matrixSum);
        }
    }
}

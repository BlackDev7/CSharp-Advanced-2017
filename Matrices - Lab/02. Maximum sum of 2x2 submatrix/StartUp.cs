using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Maximum_sum_of_2x2_submatrix
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var matrixRowsCols = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            var matrix = new int[matrixRowsCols[0]][];

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
            }
            var maxSum = 0;
            var maxStartingRow = 0;
            var maxStartingCol = 0;
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (col < matrix[row].Length - 1 && row < matrix.Length - 1)
                    {
                        var tempSum = 0;
                        tempSum = matrix[row][col] + matrix[row][col + 1] + matrix[row + 1][col] + matrix[row + 1][col + 1];
                        if (tempSum > maxSum)
                        {
                            maxStartingRow = row;
                            maxStartingCol = col;
                            maxSum = tempSum;
                        }
                    }
                }
            }
            
            Console.WriteLine($"{matrix[maxStartingRow][maxStartingCol]} {matrix[maxStartingRow][maxStartingCol + 1]}");
            Console.WriteLine($"{matrix[maxStartingRow + 1][maxStartingCol]} {matrix[maxStartingRow + 1][maxStartingCol + 1]}");
            Console.WriteLine(maxSum);

        }
    }
}

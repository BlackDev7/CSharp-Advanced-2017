using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Academy_Graduation
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var inputEntriesCount = int.Parse(Console.ReadLine());
            var students = new SortedDictionary<string, Stack<double>>();
            for (int i = 0; i < inputEntriesCount; i++)
            {
                ReadStudent(students);
            }
            PrintStudents(students);
        }

        private static void PrintStudents(SortedDictionary<string, Stack<double>> students)
        {
            foreach (var student in students)
            {
                var studentName = student.Key;
                var studentGrades = student.Value;
                Console.WriteLine($"{studentName} is graduated with {studentGrades.Average()}");
            }
        }

        private static void ReadStudent(SortedDictionary<string, Stack<double>> students)
        {
            var studentName = Console.ReadLine();
            var studentGrades = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            students.Add(studentName, new Stack<double>(studentGrades));
        }

    }
}

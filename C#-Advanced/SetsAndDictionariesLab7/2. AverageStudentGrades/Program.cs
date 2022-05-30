using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._AverageStudentGrades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> grades = new Dictionary<string, List<double>>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string student = input[0];
                double grade = double.Parse(input[1]);
                if (grades.ContainsKey(student))
                {
                    grades[student].Add(grade);
                }
                else
                {
                    grades.Add(student, new List<double>());
                    grades[student].Add(grade);
                }
            }
            foreach (var name in grades.Keys)
            {
                List<double> scores = grades[name];
                string gradesStr = string.Join(" ", scores.Select(s => s.ToString("f2")));
                double average = scores.Average();
                Console.WriteLine($"{name} -> {gradesStr} (avg: {average:0.00})");
            }
        }
    }
}

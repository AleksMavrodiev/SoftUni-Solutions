using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._StudentAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> studentGrades = new Dictionary<string, List<double>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string student = Console.ReadLine();
                double studentGrade = double.Parse(Console.ReadLine());
                if (studentGrades.ContainsKey(student))
                {
                    studentGrades[student].Add(studentGrade);
                }
                else
                {
                    studentGrades[student] = new List<double>();
                    studentGrades[student].Add(studentGrade);
                }
            }
            foreach (var student in studentGrades)
            {
                if (student.Value.Average() >= 4.50)
                {
                    Console.WriteLine($"{student.Key} -> {student.Value.Average():F2}");
                }
            }
        }
    }
}

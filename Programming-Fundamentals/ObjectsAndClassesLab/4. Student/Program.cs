using System;
using System.Collections.Generic;

namespace _4._Student
{
    class Student
    {
        public Student(string firstName, string lastName, int age, string hometown)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Hometown = hometown;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Hometown { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            List<Student> students = new List<Student>();
            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = command.Split();
                string firstName = cmdArgs[0];
                string lastName = cmdArgs[1];
                int age = int.Parse(cmdArgs[2]);
                string hometown = cmdArgs[3];
                Student student = new Student(firstName, lastName, age, hometown);
                students.Add(student);
            }
            string city = Console.ReadLine();
            List<Student> filteredStudetns = new List<Student>();
            filteredStudetns = students.FindAll(x => x.Hometown == city);
            foreach (Student student in filteredStudetns)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courseStudents = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                string[] inputArr = input.Split(" : ").ToArray();
                string courseName = inputArr[0];
                string regStudent = inputArr[1];

                if (!courseStudents.ContainsKey(courseName))
                {
                    courseStudents.Add(courseName, new List<string>());
                    
                }
                courseStudents[courseName].Add(regStudent);

            }

            foreach (var item in courseStudents.OrderByDescending(i => i.Value.Count))
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");
                foreach (var item2 in item.Value.OrderBy(i => i))
                {
                    Console.WriteLine($"-- {item2}");
                }


            }
        }
    }
}

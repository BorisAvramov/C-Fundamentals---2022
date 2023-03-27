using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            string input = Console.ReadLine();
            
            while (input != "end")
            {
                string[] inputArr = input.Split();

                Student student = new Student();

                student.FirstName = inputArr[0];
                student.LastName = inputArr[1];
                student.Age = int.Parse(inputArr[2]);
                student.HomeTown = inputArr[3];
                students.Add(student);
                input = Console.ReadLine();
            }
            string nameOfCity = Console.ReadLine();
            //1st way
            //List<Student> resultStudents = students.Where(x => x.HomeTown == nameOfCity).ToList();

            //foreach (var student in resultStudents)
            //{
            //    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            //}

            //2st Way
            //students.Where(x => x.HomeTown == nameOfCity).ToList().ForEach(x=> Console.WriteLine($"{x.FirstName} {x.LastName} is {x.Age} years old."));

            //3st Way
            students = students.FindAll(x => x.HomeTown == nameOfCity);
            foreach (var student in students)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }
    }
}

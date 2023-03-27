using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Students_2._0
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
                Student student = new Student(inputArr[0], inputArr[1], int.Parse(inputArr[2]), inputArr[3]);
                bool alreadyExists = false;
                for (int i = 0; i < students.Count; i++)
                {
                    if (students[i].FirstName == student.FirstName && students[i]. LastName == student.LastName)
                    {
                        alreadyExists = true;
                        students[i] = student;

                    }
                }
                if (!alreadyExists)
                {
                    students.Add(student);
                }
                

                input = Console.ReadLine();
            }
            string nameCity = Console.ReadLine();

            students.FindAll(x => x.HomeTown == nameCity).ForEach(x=> Console.WriteLine($"{x.FirstName} {x.LastName} is {x.Age} years old."));
        }
    }
}

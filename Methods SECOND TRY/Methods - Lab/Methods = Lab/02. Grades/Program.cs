using System;

namespace _02._Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());

            PrintGradeInWord(grade);

        }

        private static void PrintGradeInWord(double grade)
        {
            string word = "";
            if (grade > 2 && grade <=2.99)
            {
                word = "Fail";
            }
            else if (grade <= 3.49)
            {
                word = "Poor";
            }
            else if (grade <= 4.49)
            {
                word = "Good";
            }
            else if (grade <= 5.49)
            {
                word = "Very good";
            }
            else
            {
                word = "Excellent";
            }
            Console.WriteLine(word);
        }
    }
}

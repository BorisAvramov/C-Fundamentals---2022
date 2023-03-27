using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, double> studentGrade = new Dictionary<string, double>();
            Dictionary<string, int> studentNumOfGrades = new Dictionary<string, int>();

            for (int i = 1; i <= n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!studentGrade.ContainsKey(name))
                {
                    studentGrade.Add(name, grade);
                    studentNumOfGrades.Add(name, 1);

                }
                else
                {
                    studentNumOfGrades[name]++;
                    
                    double currAverageGrade = (grade + studentGrade[name]) / studentNumOfGrades[name];

                    studentGrade[name] = currAverageGrade;

                }


            }

            foreach (var item in studentGrade.Where(g => g.Value >= 4.50).OrderByDescending(g => g.Value))
            {
                Console.WriteLine($"{item.Key} –> {item.Value:f2}");


            }

        }
    }
}

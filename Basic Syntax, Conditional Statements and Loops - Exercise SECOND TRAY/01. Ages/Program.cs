using System;

namespace _01._Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            int ageNum = int.Parse(Console.ReadLine());
            string age = "";
            if (ageNum <= 2 && ageNum >=0)
            {
                age = "baby";
            }
            else if (ageNum <= 13)
            {
                age = "child";
            }
            else if (ageNum <= 19)
            {
                age = "teenager";
            }
            else if (ageNum <= 65)
            {
                age = "adult";
            }
            else
            {
                age = "elder";
            }
            Console.WriteLine(age);


        }
    }
}

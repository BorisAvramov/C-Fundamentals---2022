using System;
using System.Text.RegularExpressions;

namespace _2._Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"\+359( |-)2\1\d{3}\1\d{4}\b";
            Regex regex = new Regex(pattern);

            MatchCollection mathedNubures = regex.Matches(input);

            //string[] matchPhones = validPhonesNumber.Cast<Match>().Select(a => a.Value.Trim()).ToArray();
            //Console.WriteLine(String.Join(", ", matchPhones));

            Console.Write(string.Join(", ", mathedNubures));



            

        }
    }
}

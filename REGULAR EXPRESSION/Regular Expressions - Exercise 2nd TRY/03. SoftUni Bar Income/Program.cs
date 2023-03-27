using System;
using System.Text.RegularExpressions;
using System.Linq;
namespace _03._SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"%(?<customer>[A-Z][a-z]+)%[^|%$.]*<(?<product>\w+)>[^|%$.]*\|(?<count>\d+)\|[^|$%.]*?(?<price>\d+\.?\d*)\$";
            Regex regex = new Regex(pattern);

            double totalIncome = 0;
            
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end of shift")
                {
                    break;

                }
                MatchCollection matchOrders = regex.Matches(input);

                foreach (Match item in matchOrders)
                {
                    double totalPrice = int.Parse(item.Groups["count"].Value) * double.Parse(item.Groups["price"].Value);
                   totalIncome += totalPrice;
                    Console.WriteLine($"{item.Groups["customer"].Value}: {item.Groups["product"].Value} - {totalPrice:f2}");
                }
               


            }
            Console.WriteLine($"Total income: {totalIncome:f2}");

        }
    }
}

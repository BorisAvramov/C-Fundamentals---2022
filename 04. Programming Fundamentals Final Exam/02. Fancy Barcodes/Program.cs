using System;
using System.Text.RegularExpressions;

namespace _02._Fancy_Barcodes
{
    class Program
    {

        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            
            string pattern = @"[@][#]+[A-Z][a-zA-Z0-9]{4,}[A-Z][@][#]+";
            Regex regex = new Regex(pattern);

            for (int i = 1; i <= count; i++)
            {
                string barcod = Console.ReadLine();
                string group = "";
                if (regex.IsMatch(barcod))
                {
                    bool isDigit = false;
                    foreach (var item in barcod)
                    {
                        if (char.IsDigit(item))
                        {
                            group += item;
                            isDigit = true;
                        }

                    }
                    if (!isDigit)
                    {
                        group = "00";
                    }
                    Console.WriteLine($"Product group: {group}");

                    //1 nachin
                    //MatchCollection regexGroup = Regex.Matches(barcod, @"\d");
                    //string group = "";
                    //if (regexGroup.Count > 0)
                    //{
                    //    foreach (Match item in regexGroup)
                    //    {
                    //        group += item.Value;
                    //    }
                    //}
                    //else
                    //{
                    //    group = "00";
                    //}
                    //Console.WriteLine($"Product group: {group}");

                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }




            }


        }
    }
}

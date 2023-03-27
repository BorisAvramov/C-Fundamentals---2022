using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Fancy_Barcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^@#+[A-Z][a-zA-Z0-9]{4,}[A-Z]@#+$";

            Regex regex = new Regex(pattern);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string curBarcod = Console.ReadLine();

                if (regex.IsMatch(curBarcod))
                {
                    string proGroup = "";
                    bool isDigit = false;
                    foreach (var item in curBarcod)
                    {
                        if (char.IsDigit(item))
                        {
                            proGroup += item;
                            isDigit = true;
                        }

                    }
                    if (!isDigit)
                    {
                        proGroup = "00";
                    }

                    //string productGroup = "";
                    //foreach (var item in curBarcod.Where(char.IsDigit))
                    //{
                    //    productGroup += item;
                    //}
                    //if (productGroup.Length == 0)
                    //{
                    //    productGroup = "00";
                    //}
                    Console.WriteLine($"Product group: {proGroup}");
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
                


            }


        }
    }
}

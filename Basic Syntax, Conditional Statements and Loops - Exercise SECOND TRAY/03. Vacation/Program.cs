using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numPeople = int.Parse(Console.ReadLine());
            string typePeople = Console.ReadLine();
            string day = Console.ReadLine();
            double pricePerMan = 0;

            switch (typePeople)
            {
                case "Students":
                    if (day == "Friday")
                    {
                        pricePerMan = 8.45;
                    }
                    else if (day == "Saturday")
                    {
                        pricePerMan = 9.80;

                    }
                    else if (day == "Sunday")
                    {
                        pricePerMan = 10.46;

                    }
                   
                    break;
                case "Business":
                    if (day == "Friday")
                    {
                        pricePerMan = 10.90;
                    }
                    else if (day == "Saturday")
                    {
                        pricePerMan = 15.60;

                    }
                    else if (day == "Sunday")
                    {
                        pricePerMan = 16;

                    }
                    break;
                case "Regular":
                    if (day == "Friday")
                    {
                        pricePerMan = 15;
                    }
                    else if (day == "Saturday")
                    {
                        pricePerMan = 20;

                    }
                    else if (day == "Sunday")
                    {
                        pricePerMan = 22.50;

                    }
                    break;
                default:
                    break;
            }
            double TotalPrice = numPeople * pricePerMan;
            if (typePeople == "Students")
            {
                if (numPeople >= 30)
                {
                    TotalPrice -= TotalPrice * 0.15;
                }
            }
            else if (typePeople == "Business")
            {
                if (numPeople >= 100)
                {
                    TotalPrice -= 10 * pricePerMan;
                }
            }
            else if (typePeople == "Regular")
            {
                if (numPeople >= 10 && numPeople <= 20)
                {
                    TotalPrice -= TotalPrice * 0.05;
                }
            }

            Console.WriteLine($"Total price: {TotalPrice:F2}");


        }
    }
}

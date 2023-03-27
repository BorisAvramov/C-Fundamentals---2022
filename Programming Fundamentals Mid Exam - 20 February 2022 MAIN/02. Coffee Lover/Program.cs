using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Coffee_Lover
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> coffees = Console.ReadLine().Split().ToList();

            int numCommands = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numCommands; i++)
            {
                string[] data = Console.ReadLine().Split();

                if (data[0] == "Include")
                {
                    coffees.Add(data[1]);

                }
                else if (data[0] == "Remove")
                {
                    if (coffees.Count >= int.Parse(data[2]))
                    {
                        if (data[1] == "first")
                        {
                            coffees.RemoveRange(0, int.Parse(data[2]));
                        }

                        //arabika spetema ragazi jimbo
                            //0           1   2       3

                        else if (data[1] == "last")
                        {
                            coffees.RemoveRange((coffees.Count - int.Parse(data[2])), int.Parse(data[2]));
                        }

                    }

                }
                else if (data[0] == "Prefer")
                {
                    int index1 = int.Parse(data[1]);
                    int index2 = int.Parse(data[2]);
                    if ((index1 >= 0 && index1 < coffees.Count) && (index2 >= 0 && index2 < coffees.Count) && index1 != index2)
                    {


                        string tem1 = coffees[index1];
                        string tem2 = coffees[index2];

                        coffees[index2] = tem1;
                        coffees[index1] = tem2;




                        //coffees.RemoveAt(index1);
                        //coffees.Insert(index1, tempSecond);

                        //coffees.RemoveAt(index2);
                        //coffees.Insert(index2, tempFirst);




                    }

                }
                else if (data[0] == "Reverse")
                {
                    coffees.Reverse();
                }

            }

            Console.WriteLine("Coffees:");
            foreach (var item in coffees)
            {
                Console.Write(item + " ");
            }



        }
    }
}

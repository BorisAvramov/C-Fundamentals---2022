using System;
using System.Linq;

namespace _02._Array_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] intArr = Console.ReadLine().Split().Select(int.Parse).ToArray();


            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }

                string[] data = command.Split().ToArray();
                string cmmand2 = data[0];

                if (cmmand2 == "swap")
                {
                    int index1 = int.Parse(data[1]);
                    int index2 = int.Parse(data[2]);
                    int tempIndex1 = intArr[index1];
                    intArr[index1] = intArr[index2];
                    intArr[index2] = tempIndex1;
                }
                else if (cmmand2 == "multiply")
                {
                    int index1 = int.Parse(data[1]);
                    int index2 = int.Parse(data[2]);
                    intArr[index1] = intArr[index1] * intArr[index2];
                }
                else
                {
                    for (int i = 0; i < intArr.Length; i++)
                    {
                        intArr[i]--;


                    }
                }
                
                

        }
            


            Console.WriteLine(string.Join(" ", intArr));

        }
    }
}

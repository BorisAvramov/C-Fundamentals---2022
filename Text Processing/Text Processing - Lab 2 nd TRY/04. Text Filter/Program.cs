using System;
using System.Linq;
using System.Text;

namespace _04._Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ").ToArray();
            //string text = Console.ReadLine();
            char[] separators = new char[] { ' ', ',', '.', '!' };
            string text = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            foreach (var item in text)
            {
                sb.Append(item);
            }
            
            for (int i = 0; i < bannedWords.Length; i++)
            {
                
                sb.Replace(bannedWords[i], new string('*', bannedWords[i].Length));

            }

            //for (int i = 0; i < bannedWords.Length; i++)
            //{
            //    while (text.Contains(bannedWords[i]))
            //    {
            //       text =  text.Replace(bannedWords[i], new string ('*', bannedWords[i].Length ));


            //    }


            //}
            
            Console.WriteLine(sb);
        }
    }
}

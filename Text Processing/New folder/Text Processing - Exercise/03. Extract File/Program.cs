using System;

namespace _03._Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();

            string fileName = "";
            string ext = "";

            string fileNameAndExt = path.Substring(path.LastIndexOf('\\')+1);

            fileName =  fileNameAndExt.Substring(0, fileNameAndExt.IndexOf('.'));

            ext = fileNameAndExt.Substring(fileNameAndExt.IndexOf('.')+1);

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {ext}");



            //string[] path = Console.ReadLine().Split("\\").ToArray();

            //string[] nameAndExt = path[path.Length - 1].Split('.');

            //Console.WriteLine($"File name: {nameAndExt[0]}");
            //Console.WriteLine($"File extension: {nameAndExt[1]}");
            //string name = path.Substring();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Person> persons = new List<Person>();
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                string[] data = input.Split().ToArray();

                string name = data[0];
                string id = data[1];
                int age = int.Parse(data[2]);
                bool idOcc = false;
                foreach (var item in persons)
                {
                    if (item.Id == id)
                    {
                        idOcc = true;
                        item.Name = name;
                        item.Age = age;
                    }
                }
                if (!idOcc)
                {
                    Person person = new Person(name, id, age);

                    persons.Add(person);

                }

            }

            foreach (var item in persons.OrderBy(i => i.Age))
            {
                Console.WriteLine($"{item.Name} with ID: {item.Id} is {item.Age} years old.");


            }

        }
    }
}

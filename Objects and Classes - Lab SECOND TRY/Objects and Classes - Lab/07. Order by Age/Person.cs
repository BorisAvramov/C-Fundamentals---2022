using System;
using System.Collections.Generic;
using System.Text;

namespace _07._Order_by_Age
{
    class Person
    {
        public Person(string name, string id, int age)
        {
            this.Name = name;
            this.Id = id;
            this.Age = age;
        }

        public int Age { get; set; }
        public string Name { get; set; }
        public string Id { get; set; }
    }
}

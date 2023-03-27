using System;
using System.Collections.Generic;
using System.Text;

namespace _05._Students_2._0
{
    class Student
    {

        public Student(string firstName, string lastName, int age, string homeTown)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            HomeTown = homeTown;


        }
        public string FirstName  { get; set; }
        public string LastName  { get; set; }
        public int Age  { get; set; }
        public string HomeTown  { get; set; }


    }
}

using System;
using ProgrammingSchool.Modules;
using ProgrammingSchool.Persons;
using ProgrammingSchool.Utilities;

namespace ProgrammingSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            var school = new School();

            var student = new Student("Jan", DateTime.Now, "+48 605 337 334", school);

            Console.WriteLine(school.Modules[0].Persons[0].Name);
        }
    }
}
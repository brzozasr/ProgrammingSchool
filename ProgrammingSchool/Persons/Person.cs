using System;

namespace ProgrammingSchool.Persons
{
    public abstract class Person
    {
        protected string Name { get; set; }
        protected DateTime Birthday { get; set; }
        protected string PhoneNo { get; set; }

        protected Person(string name, DateTime birthday, string phoneNo)
        {
            Name = name;
            Birthday = birthday;
            PhoneNo = phoneNo;
        }
    }
}
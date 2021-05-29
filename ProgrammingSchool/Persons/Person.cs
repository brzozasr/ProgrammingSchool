using System;

namespace ProgrammingSchool.Persons
{
    public abstract class Person
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string PhoneNo { get; set; }

        protected Person(string name, DateTime birthday, string phoneNo)
        {
            Id = Guid.NewGuid();
            Name = name;
            Birthday = birthday;
            PhoneNo = phoneNo;
        }

        public abstract void DoActivity();
    }
}
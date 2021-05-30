using System.Collections.Generic;
using System.Linq;
using ProgrammingSchool.Persons;
using ProgrammingSchool.Utilities;

namespace ProgrammingSchool.Modules
{
    public abstract class Module
    {
        public abstract ModuleName Name { get; }
        public abstract ModuleLanguage UsedLanguage { get; }
        public abstract List<Person> Persons { get; set; }
        
        public bool RemovePerson(Person person)
        {
            var elementToRemove = Persons.SingleOrDefault(p => p.Id == person.Id);
            if (elementToRemove is not null)
            {
                Persons.Remove(elementToRemove);
                return true;
            }

            return false;
        }

        public bool AddPerson(Person person)
        {
            if (person is not null)
            {
                Persons.Add(person);
                return true;
            }

            return false;
        }

        public bool IsMentorAvailable()
        {
            return Persons.OfType<Mentor>().Any();
        }
        
        public bool IsSalesPersonAvailable()
        {
            return Persons.OfType<SalesPerson>().Any();
        }
    }
}
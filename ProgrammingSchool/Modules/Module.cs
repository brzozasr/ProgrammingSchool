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
        // public static List<Module> Modules { get; } = new();

        // public bool AddModule(Module module)
        // {
        //     if (module is not null)
        //     {
        //         Modules.Add(module);
        //         return true;
        //     }
        //
        //     return false;
        // }
        //
        // public Module GetBasicModule()
        // {
        //     return Modules.Find(m => m.Name == ModuleName.Basic);
        // }
        //
        // public Module GetNextModule(Module module)
        // {
        //     switch (module.Name)
        //     {
        //         case ModuleName.Basic:
        //             return Modules.Find(m => m.Name == ModuleName.Web);
        //         case ModuleName.Web:
        //             return Modules.Find(m => m.Name == ModuleName.OOP);
        //         case ModuleName.OOP:
        //             return Modules.Find(m => m.Name == ModuleName.Advanced);
        //         case ModuleName.Advanced:
        //             return Modules.Find(m => m.Name == ModuleName.OTJ);
        //         case ModuleName.OTJ:
        //             return null;
        //         default:
        //             return null;
        //     }
        // }

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
    }
}
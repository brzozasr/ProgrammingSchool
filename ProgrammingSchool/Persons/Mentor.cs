using System;
using System.Reflection;
using ProgrammingSchool.Modules;
using ProgrammingSchool.Utilities;
using Module = ProgrammingSchool.Modules.Module;

namespace ProgrammingSchool.Persons
{
    public class Mentor : Person
    {
        public ModuleLanguage ProgrammingLanguage { get; private set; }
        public Module CurrentModuleName { get; private set; }
        
        public Mentor(string name, DateTime birthday, string phoneNo, ModuleLanguage moduleLanguage, Module module) 
            : base(name, birthday, phoneNo)
        {
            ProgrammingLanguage = moduleLanguage;
            
            if (module.UsedLanguage == ProgrammingLanguage)
            {
                CurrentModuleName = module;
            }
        }

        public override void DoActivity()
        {
            throw new NotImplementedException();
        }
    }
}
using System;
using ProgrammingSchool.Utilities;
using Module = ProgrammingSchool.Modules.Module;

namespace ProgrammingSchool.Persons
{
    public class Mentor : Person
    {
        public ModuleLanguage ProgrammingLanguage { get; private set; }
        public School School { get; private set; }
        public double Salary { get; private set; }
        private Module _module { get; set; }
        
        public Mentor(string name, DateTime birthday, string phoneNo, ModuleLanguage moduleLanguage, School school) 
            : base(name, birthday, phoneNo)
        {
            ProgrammingLanguage = moduleLanguage;
            School = school;
            Salary = Util.Random.SalaryGenerator(8000.0, 12000.0);

            if (School.GetModuleByProgrammingLanguage(ProgrammingLanguage) is var mod && mod is not null)
            {
                _module = mod;
                mod.AddPerson(this);
            }
        }

        public override void DoActivity()
        {
        }
    }
}
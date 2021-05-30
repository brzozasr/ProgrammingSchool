using System;
using ProgrammingSchool.Modules;
using ProgrammingSchool.Utilities;

namespace ProgrammingSchool.Persons
{
    public class SalesPerson : Person
    {
        public double Salary { get; }
        public School School { get; private set; }
        private Module _module { get; set; }
        
        public SalesPerson(string name, DateTime birthday, string phoneNo, School school) 
            : base(name, birthday, phoneNo)
        {
            School = school;
            Salary = Util.Random.SalaryGenerator(5000.0, 9000.0);
            
            if (School.GetModuleByProgrammingLanguage(ModuleLanguage.None) is var mod && mod is not null)
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
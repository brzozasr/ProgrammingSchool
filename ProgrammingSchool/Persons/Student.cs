using System;
using ProgrammingSchool.Modules;
using ProgrammingSchool.Utilities;

namespace ProgrammingSchool.Persons
{
    public class Student : Person
    {
        public School School { get; private set; }
        public uint ModuleProgress { get; private set; }

        public Student(string name, DateTime birthday, string phoneNo, School school, uint moduleProgress = 0) 
            : base(name, birthday, phoneNo)
        {
            ModuleProgress = moduleProgress >= 100 ? 0 : moduleProgress;
            School = school;
            if (School.GetCurrentModule(Id) is var mod && mod is not null)
            {
                mod.AddPerson(this);
            }
            else
            {
                School.GetBasicModule().AddPerson(this);
            }
        }

        public override void DoActivity()
        {
            uint progress = 10;
            uint progressOTJ = 25;
            var module = School.GetCurrentModule(Id);
            
            switch (module.Name)
            {
                case ModuleName.Basic:
                    if (ModuleProgress < 100)
                    {
                        ModuleProgress += progress;
                    }
                    else
                    {
                        ModuleProgress = 0;
                        module.RemovePerson(this);
                        module = School.GetNextModule(module);
                        module.AddPerson(this);
                    }
                    break;
                case ModuleName.Web:
                    if (ModuleProgress < 100)
                    {
                        ModuleProgress += progress;
                    }
                    else
                    {
                        ModuleProgress = 0;
                        module.RemovePerson(this);
                        module = School.GetNextModule(module);
                        module.AddPerson(this);
                    }
                    break;
                case ModuleName.OOP:
                    if (ModuleProgress < 100)
                    {
                        ModuleProgress += progress;
                    }
                    else
                    {
                        ModuleProgress = 0;
                        module.RemovePerson(this);
                        module = School.GetNextModule(module);
                        module.AddPerson(this);
                    }
                    break;
                case ModuleName.Advanced:
                    if (ModuleProgress < 100)
                    {
                        ModuleProgress += progress;
                    }
                    else
                    {
                        ModuleProgress = 0;
                        module.RemovePerson(this);
                        module = School.GetNextModule(module);
                        module.AddPerson(this);
                    }
                    break;
                case ModuleName.OTJ:
                    if (ModuleProgress < 100)
                    {
                        ModuleProgress += progressOTJ;
                    }
                    else
                    {
                        ModuleProgress = 0;
                        module.RemovePerson(this);
                    }
                    break;
                default:
                    ModuleProgress = 0;
                    module.RemovePerson(this);
                    module = School.GetBasicModule();
                    module.AddPerson(this);
                    break;
            }
        }
    }
}
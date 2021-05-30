using System;
using ProgrammingSchool.Modules;
using ProgrammingSchool.Utilities;

namespace ProgrammingSchool.Persons
{
    public class Student : Person
    {
        public School School { get; private set; }
        public uint ModuleProgress { get; private set; }
        private Module _module { get; set; }

        public Student(string name, DateTime birthday, string phoneNo, School school, 
            ModuleName moduleName = ModuleName.Basic, uint moduleProgress = 0) 
            : base(name, birthday, phoneNo)
        {
            ModuleProgress = moduleProgress >= 100 ? 0 : moduleProgress;
            School = school;
            if (School.GetCurrentModule(Id) is var mod && mod is not null)
            {
                _module = mod;
                mod.AddPerson(this);
            }
            else if (School.GetModuleByName(moduleName) is var mod1 && mod1 is not null)
            {
                _module = mod1;
                mod1.AddPerson(this);
            }
            else
            {
                var module = School.GetBasicModule();
                module.AddPerson(this);
                _module = module;
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
                        if (_module.IsMentorAvailable())
                        {
                            ModuleProgress += progress;
                        }
                    }
                    else
                    {
                        ModuleProgress = 0;
                        module.RemovePerson(this);
                        module = School.GetNextModule(module);
                        _module = module;
                        module.AddPerson(this);
                    }
                    break;
                case ModuleName.Web:
                    if (ModuleProgress < 100)
                    {
                        if (_module.IsMentorAvailable())
                        {
                            ModuleProgress += progress;
                        }
                    }
                    else
                    {
                        ModuleProgress = 0;
                        module.RemovePerson(this);
                        module = School.GetNextModule(module);
                        _module = module;
                        module.AddPerson(this);
                    }
                    break;
                case ModuleName.OOP:
                    if (ModuleProgress < 100)
                    {
                        if (_module.IsMentorAvailable())
                        {
                            ModuleProgress += progress;
                        }
                    }
                    else
                    {
                        ModuleProgress = 0;
                        module.RemovePerson(this);
                        module = School.GetNextModule(module);
                        _module = module;
                        module.AddPerson(this);
                    }
                    break;
                case ModuleName.Advanced:
                    if (ModuleProgress < 100)
                    {
                        if (_module.IsMentorAvailable())
                        {
                            ModuleProgress += progress;
                        }
                    }
                    else
                    {
                        ModuleProgress = 0;
                        module.RemovePerson(this);
                        module = School.GetNextModule(module);
                        _module = module;
                        module.AddPerson(this);
                    }
                    break;
                case ModuleName.OTJ:
                    if (ModuleProgress < 100)
                    {
                        if (_module.IsSalesPersonAvailable())
                        {
                            ModuleProgress += progressOTJ;
                        }
                    }
                    else
                    {
                        ModuleProgress = 0;
                        module.RemovePerson(this);
                        _module = null;
                    }
                    break;
                default:
                    ModuleProgress = 0;
                    module.RemovePerson(this);
                    module = School.GetBasicModule();
                    _module = module;
                    module.AddPerson(this);
                    break;
            }
        }
    }
}
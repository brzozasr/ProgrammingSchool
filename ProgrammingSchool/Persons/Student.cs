using System;
using ProgrammingSchool.Modules;
using ProgrammingSchool.Utilities;

namespace ProgrammingSchool.Persons
{
    public class Student : Person
    {
        public IModule Module { get; private set; }
        public uint ModuleProgress { get; private set; }

        public Student(string name, DateTime birthday, string phoneNo, IModule module, uint moduleProgress = 0) 
            : base(name, birthday, phoneNo)
        {
            Module = module;
            ModuleProgress = moduleProgress >= 100 ? 0 : moduleProgress;
        }


        public override void DoActivity()
        {
            uint progress = 10;
            switch (Module.Name)
            {
                case ModuleName.Basic:
                    if (ModuleProgress < 100)
                    {
                        ModuleProgress += progress;
                    }
                    else
                    {
                        ModuleProgress = 0;
                        Module = new Web();
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
                        Module = new OOP();
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
                        Module = new Advanced();
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
                        Module = new OTJ();
                    }
                    break;
                case ModuleName.OTJ:
                    break;
                default:
                    ModuleProgress = 0;
                    Module = new Basic();
                    break;
            }
        }
    }
}
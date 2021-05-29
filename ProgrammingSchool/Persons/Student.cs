using System;
using ProgrammingSchool.Utilities;

namespace ProgrammingSchool.Persons
{
    public class Student : Person
    {
        public Module Module { get; private set; }
        public uint ModuleProgress { get; private set; }

        public Student(string name, DateTime birthday, string phoneNo, Module module = Module.Basic, uint moduleProgress = 0) 
            : base(name, birthday, phoneNo)
        {
            Module = module;
            ModuleProgress = moduleProgress >= 100 ? 0 : moduleProgress;
        }

        public void SetModuleProgress()
        {
            
        }
    }
}
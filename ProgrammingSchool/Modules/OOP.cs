using System;
using System.Collections.Generic;
using ProgrammingSchool.Persons;
using ProgrammingSchool.Utilities;

namespace ProgrammingSchool.Modules
{
    public class OOP : Module
    {
        public override ModuleName Name => ModuleName.OOP;
        public override ModuleLanguage UsedLanguage => ModuleLanguage.JavaSE;
        public override List<Person> Persons { get; set; } = new();

        private static readonly Lazy<OOP> Lazy =
            new Lazy<OOP>(() => new OOP());
        
        public static OOP Instance => Lazy.Value;

        private OOP()
        {
        }
    }
}
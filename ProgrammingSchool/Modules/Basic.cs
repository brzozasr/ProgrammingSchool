using System;
using System.Collections.Generic;
using ProgrammingSchool.Persons;
using ProgrammingSchool.Utilities;

namespace ProgrammingSchool.Modules
{
    public class Basic : Module
    {
        public override ModuleName Name => ModuleName.Basic;
        public override ModuleLanguage UsedLanguage => ModuleLanguage.Python;
        public override List<Person> Persons { get; set; } = new();

        private static readonly Lazy<Basic> Lazy =
            new Lazy<Basic>(() => new Basic());
        
        public static Basic Instance => Lazy.Value;

        private Basic()
        {
        }
    }
}
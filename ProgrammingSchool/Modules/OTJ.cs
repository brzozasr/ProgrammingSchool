using System;
using System.Collections.Generic;
using ProgrammingSchool.Persons;
using ProgrammingSchool.Utilities;

namespace ProgrammingSchool.Modules
{
    public class OTJ : Module
    {
        public override ModuleName Name => ModuleName.OTJ;
        public override ModuleLanguage UsedLanguage => ModuleLanguage.None;
        public override List<Person> Persons { get; set; } = new();

        private static readonly Lazy<OTJ> Lazy =
            new Lazy<OTJ>(() => new OTJ());
        
        public static OTJ Instance => Lazy.Value;

        private OTJ()
        {
        }
    }
}
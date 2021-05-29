using System;
using System.Collections.Generic;
using ProgrammingSchool.Persons;
using ProgrammingSchool.Utilities;

namespace ProgrammingSchool.Modules
{
    public class Web : Module
    {
        public override ModuleName Name => ModuleName.Web;
        public override ModuleLanguage UsedLanguage => ModuleLanguage.Web;
        public override List<Person> Persons { get; set; } = new();

        private static readonly Lazy<Web> Lazy =
            new Lazy<Web>(() => new Web());
        
        public static Web Instance => Lazy.Value;

        private Web()
        {
        }
    }
}
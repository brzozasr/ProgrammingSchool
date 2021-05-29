using System;
using System.Collections.Generic;
using ProgrammingSchool.Persons;
using ProgrammingSchool.Utilities;

namespace ProgrammingSchool.Modules
{
    public class Advanced : Module
    {
        public override ModuleName Name => ModuleName.Advanced;
        public override ModuleLanguage UsedLanguage => ModuleLanguage.JavaEE;
        public override List<Person> Persons { get; set; } = new();

        private static readonly Lazy<Advanced> Lazy =
            new Lazy<Advanced>(() => new Advanced());

        public static Advanced Instance => Lazy.Value;

        private Advanced()
        {
        }
    }
}
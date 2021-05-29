using ProgrammingSchool.Utilities;

namespace ProgrammingSchool.Modules
{
    public class Advanced : IModule
    {
        public ModuleName Name => ModuleName.Advanced;
        public ModuleLanguage UsedLanguage => ModuleLanguage.JavaEE;
    }
}
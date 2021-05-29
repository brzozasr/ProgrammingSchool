using ProgrammingSchool.Utilities;

namespace ProgrammingSchool.Modules
{
    public class Basic : IModule
    {
        public ModuleName Name => ModuleName.Basic;
        public ModuleLanguage UsedLanguage => ModuleLanguage.Python;
    }
}
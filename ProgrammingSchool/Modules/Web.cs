using ProgrammingSchool.Utilities;

namespace ProgrammingSchool.Modules
{
    public class Web : IModule
    {
        public ModuleName Name => ModuleName.Web;
        public ModuleLanguage UsedLanguage => ModuleLanguage.Web;
    }
}
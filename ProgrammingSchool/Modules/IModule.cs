using ProgrammingSchool.Utilities;

namespace ProgrammingSchool.Modules
{
    public interface IModule
    {
        ModuleName Name { get; }
        ModuleLanguage UsedLanguage { get; }
    }
}
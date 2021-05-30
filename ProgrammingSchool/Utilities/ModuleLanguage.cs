using System.ComponentModel.DataAnnotations;

namespace ProgrammingSchool.Utilities
{
    public enum ModuleLanguage
    {
        Python,
        Web,
        [Display(Name="Java SE")]
        JavaSE,
        [Display(Name="Java EE")]
        JavaEE,
        None
    }
}
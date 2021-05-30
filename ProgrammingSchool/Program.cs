using System;
using ProgrammingSchool.Modules;
using ProgrammingSchool.Persons;
using ProgrammingSchool.Utilities;

namespace ProgrammingSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            var school = new School();

            var student = new Student(Util.GetRandomName(), Util.GetRandomBirthday(), Util.GetRandomPhoneNo(), school);
            var student1 = new Student(Util.GetRandomName(), Util.GetRandomBirthday(), Util.GetRandomPhoneNo(), school);
            var student2 = new Student(Util.GetRandomName(), Util.GetRandomBirthday(), Util.GetRandomPhoneNo(), school);

            var student3 = new Student(Util.GetRandomName(), Util.GetRandomBirthday(), Util.GetRandomPhoneNo(), school, ModuleName.Web);
            var student4 = new Student(Util.GetRandomName(), Util.GetRandomBirthday(), Util.GetRandomPhoneNo(), school, ModuleName.Web);
            var student5 = new Student(Util.GetRandomName(), Util.GetRandomBirthday(), Util.GetRandomPhoneNo(), school, ModuleName.Web);

            var student6 = new Student(Util.GetRandomName(), Util.GetRandomBirthday(), Util.GetRandomPhoneNo(), school, ModuleName.OOP);
            var student7 = new Student(Util.GetRandomName(), Util.GetRandomBirthday(), Util.GetRandomPhoneNo(), school, ModuleName.OOP);
            var student8 = new Student(Util.GetRandomName(), Util.GetRandomBirthday(), Util.GetRandomPhoneNo(), school, ModuleName.OOP);

            var student9 = new Student(Util.GetRandomName(), Util.GetRandomBirthday(), Util.GetRandomPhoneNo(), school, ModuleName.Advanced);
            var student10 = new Student(Util.GetRandomName(), Util.GetRandomBirthday(), Util.GetRandomPhoneNo(), school, ModuleName.Advanced);
            var student11 = new Student(Util.GetRandomName(), Util.GetRandomBirthday(), Util.GetRandomPhoneNo(), school, ModuleName.Advanced);

            
            var mentor = new Mentor(Util.GetRandomName(), Util.GetRandomBirthday(), Util.GetRandomPhoneNo(), ModuleLanguage.Python,
                school);
            var mentor1 = new Mentor(Util.GetRandomName(), Util.GetRandomBirthday(), Util.GetRandomPhoneNo(), ModuleLanguage.Web,
                school);
            var mentor2 = new Mentor(Util.GetRandomName(), Util.GetRandomBirthday(), Util.GetRandomPhoneNo(), ModuleLanguage.JavaSE,
                school);
            var mentor3 = new Mentor(Util.GetRandomName(), Util.GetRandomBirthday(), Util.GetRandomPhoneNo(), ModuleLanguage.JavaEE,
                school);

            var salesPerson = new SalesPerson(Util.GetRandomName(), Util.GetRandomBirthday(), Util.GetRandomPhoneNo(), school);

            school.ExecuteActionAndDisplay();
        }
    }
}
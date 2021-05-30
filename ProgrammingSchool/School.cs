using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using ProgrammingSchool.Modules;
using ProgrammingSchool.Persons;
using ProgrammingSchool.Utilities;

namespace ProgrammingSchool
{
    public class School
    {
        public List<Module> Modules { get; } = new()
        {
            Basic.Instance,
            Web.Instance,
            OOP.Instance,
            Advanced.Instance,
            OTJ.Instance
        };

        public Module GetBasicModule()
        {
            return Modules.Find(m => m.Name == ModuleName.Basic);
        }

        public Module GetCurrentModule(Guid id)
        {
            foreach (var module in Modules)
            {
                var person = module.Persons.SingleOrDefault(u => u.Id == id);
                if (person is not null)
                {
                    return module;
                }
            }

            return null;
        }

        public Module GetModuleByProgrammingLanguage(ModuleLanguage moduleLanguage)
        {
            return Modules.SingleOrDefault(x => x.UsedLanguage == moduleLanguage);
        }
        
        public Module GetModuleByName(ModuleName moduleName)
        {
            return Modules.SingleOrDefault(x => x.Name == moduleName);
        }

        public Module GetNextModule(Module module)
        {
            switch (module.Name)
            {
                case ModuleName.Basic:
                    return Modules.Find(m => m.Name == ModuleName.Web);
                case ModuleName.Web:
                    return Modules.Find(m => m.Name == ModuleName.OOP);
                case ModuleName.OOP:
                    return Modules.Find(m => m.Name == ModuleName.Advanced);
                case ModuleName.Advanced:
                    return Modules.Find(m => m.Name == ModuleName.OTJ);
                case ModuleName.OTJ:
                    return null;
                default:
                    return null;
            }
        }

        public void ExecuteActionAndDisplay()
        {
            Console.Clear();

            StringBuilder sb = new StringBuilder();
            do
            {
                sb.Clear();

                for (int i = 0; i < Modules.Count; i++)
                {
                    var module = Modules[i];
                    sb.AppendLine($"Module name: {module.Name}");
                    for (int j = module.Persons.Count - 1; j >= 0; j--)
                    {
                        var person = module.Persons[j];

                        if (person is Mentor mentor)
                        {
                            sb.AppendLine(
                                $" - Mentor: {mentor.Name} :: {mentor.ProgrammingLanguage} :: {mentor.Salary} zł :: {mentor.Birthday:dd-MM-yyyy} :: {mentor.PhoneNo}");
                        }

                        if (person is SalesPerson salesPerson)
                        {
                            sb.AppendLine(
                                $" - Sales: {salesPerson.Name} :: {salesPerson.Salary} zł:: {salesPerson.Birthday:dd-MM-yyyy} :: {salesPerson.PhoneNo}");
                        }

                        if (person is Student {ModuleProgress: < 100} student)
                        {
                            sb.AppendLine(
                                $" - Student: {student.Name} :: {student.ModuleProgress}% :: {student.Birthday:dd-MM-yyyy} :: {student.PhoneNo}");
                        }

                        person.DoActivity();
                    }
                }

                Console.WriteLine(sb.ToString());

                Thread.Sleep(1000);
                Console.Clear();
            } while (sb.ToString().Contains(" - Student: "));
        }
    }
}
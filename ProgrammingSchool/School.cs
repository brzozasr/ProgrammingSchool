using System;
using System.Collections.Generic;
using System.Linq;
using ProgrammingSchool.Modules;
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
    }
}
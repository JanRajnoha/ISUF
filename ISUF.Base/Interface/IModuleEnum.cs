using ISUF.Base.Modules;
using ISUF.Base.Template;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.Base.Interface
{
    interface IModuleEnum
    {
        bool RegisterModule(Type moduleType);   

        bool RegisterModule(Type moduleType, string moduleName);

        bool RegisterModule(Module module);

        bool ExistModule(Type moduleType);

        bool ExistModule(Type moduleType, string moduleName);

        bool ExistModule(Module module);

        bool ExistModule(string moduleName);

        bool RemoveModule(Type moduleType, bool RemoveAll = false);

        bool RemoveModule(Type moduleType, string moduleName);

        bool RemoveModule(int index);

        bool RemoveModule(Module module);

        int ModuleCount();

        Module GetModule(Type moduleType);

        Module GetModule(Type moduleType, string moduleName);

        Module GetModule(int index);

        Module GetModule(string moduleName);

        List<Module> GetModules();
    }
}

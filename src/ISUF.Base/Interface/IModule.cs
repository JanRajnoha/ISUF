using ISUF.Base.Modules;
using ISUF.Base.Template;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.Base.Interface
{
    /// <summary>
    /// Module interface
    /// </summary>
    public interface IModule
    {
        /// <summary>
        /// Set module manager into module
        /// </summary>
        /// <param name="moduleManager">Module manager</param>
        void SetModuleManager(ModuleManager moduleManager);
    }
}

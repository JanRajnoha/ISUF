using ISUF.Base.Interface;
using ISUF.Base.Template;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.Base.Modules
{
    /// <summary>
    /// Base class for creating modules grouping all classes, that work with data of selected item type
    /// </summary>
    public partial class Module : IModule
    {
        Type moduleType;
        string moduleName;

        public Module(Type moduleType)
        {
            this.moduleType = moduleType;
            moduleName = moduleType.ToString();
        }

        public Module(Type moduleType, string moduleName) : this(moduleType)
        {
            this.moduleName = moduleName;
        }

        /// <summary>
        /// Return name of module. Default value is type of item converted into string
        /// </summary>
        /// <returns>Name of module</returns>
        public string GetModuleName()
        {
            return moduleName;
        }

        /// <summary>
        /// Return type of module
        /// </summary>
        /// <returns>Type of module</returns>
        public Type GetModuleType()
        {
            return moduleType;
        }
    }
}

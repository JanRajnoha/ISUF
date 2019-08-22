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
    public class Module : IModule
    {
        protected Type moduleItemType { get; set; }
        protected string moduleName { get; set; }

        /// <summary>
        /// Create module by type. 
        /// </summary>
        /// <param name="moduleItemType">Type of module</param>
        public Module(Type moduleItemType)
        {
            this.moduleItemType = moduleItemType;
            moduleName = moduleItemType.ToString();
        }
        
        /// <summary>
        /// Create module by type and name
        /// </summary>
        /// <param name="moduleItemType">Type of module</param>
        /// <param name="moduleName">Name of module</param>
        public Module(Type moduleItemType, string moduleName) : this(moduleItemType)
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
            return moduleItemType;
        }
    }
}

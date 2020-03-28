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
        /// <summary>
        /// Item type of module
        /// </summary>
        public Type ModuleItemType { get; private set; }

        /// <summary>
        /// Module name
        /// </summary>
        public string ModuleName { get; private set; }

        protected ModuleManager moduleManager;

        /// <summary>
        /// Create module by type.
        /// </summary>
        /// <param name="moduleItemType">Type of module</param>
        public Module(Type moduleItemType)
        {
            ModuleItemType = moduleItemType;
            ModuleName = moduleItemType.Name;
        }
        
        /// <summary>
        /// Create module by type and name
        /// </summary>
        /// <param name="moduleItemType">Type of module</param>
        /// <param name="moduleName">Name of module</param>
        public Module(Type moduleItemType, string moduleName) : this(moduleItemType)
        {
            ModuleName = moduleName;
        }

        /// <summary>
        /// <inheritdoc />
        /// </summary>
        /// <param name="moduleManager"><inheritdoc /></param>
        public void SetModuleManager(ModuleManager moduleManager) => this.moduleManager = moduleManager;
    }
}

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
    /// Module enum interface
    /// </summary>
    interface IModuleEnum
    {
        /// <summary>
        /// Register module with selected type
        /// </summary>
        /// <param name="moduleType">Type of module</param>
        /// <returns>Registration completed succesfully</returns>
        bool RegisterModule(Type moduleType);

        /// <summary>
        /// Register module with selected type and name
        /// </summary>
        /// <param name="moduleType">Type of module</param>
        /// <param name="moduleName">Name of module</param>
        /// <returns>Registration completed succesfully</returns>
        bool RegisterModule(Type moduleType, string moduleName);

        /// <summary>
        /// Register module
        /// </summary>
        /// <param name="module">Module</param>
        /// <returns>Registration completed succesfully</returns>
        bool RegisterModule(Module module);

        /// <summary>
        /// Check existence of module
        /// </summary>
        /// <param name="moduleType">Type of module</param>
        /// <returns>Existence of module</returns>
        bool ExistModule(Type moduleType);

        /// <summary>
        /// Check existence of module
        /// </summary>
        /// <param name="moduleType">Type of module</param>
        /// <param name="moduleName">Name of module</param>
        /// <returns>Existence of module</returns>
        bool ExistModule(Type moduleType, string moduleName);

        /// <summary>
        /// Check existence of module
        /// </summary>
        /// <param name="module">Module</param>
        /// <returns>Existence of module</returns>
        bool ExistModule(Module module);

        /// <summary>
        /// Check existence of module
        /// </summary>
        /// <param name="moduleName">Name of module</param>
        /// <returns>Existence of module</returns>
        bool ExistModule(string moduleName);

        /// <summary>
        /// Remove module by type.
        /// </summary>
        /// <param name="moduleType">Type of module</param>
        /// <param name="removeAll">Remove all modules with same type</param>
        /// <returns>Operation completed succesfully</returns>
        bool RemoveModule(Type moduleType, bool RemoveAll = false);

        /// <summary>
        /// Remove module by type and name
        /// </summary>
        /// <param name="moduleType">Type of module</param>
        /// <param name="moduleName">Name of module</param>
        /// <returns>Operation completed succesfully</returns>
        bool RemoveModule(Type moduleType, string moduleName);

        /// <summary>
        /// Remove module on selected index
        /// </summary>
        /// <param name="index">Index of module</param>
        /// <returns>Operation completed succesfully</returns>
        bool RemoveModule(int index);

        /// <summary>
        /// Remove module
        /// </summary>
        /// <param name="module">Module</param>
        /// <returns>Operation completed succesfully</returns>
        bool RemoveModule(Module module);

        /// <summary>
        /// Return count of modules
        /// </summary>
        /// <returns>Count of modules</returns>
        int ModuleCount();

        /// <summary>
        /// Return module by type
        /// </summary>
        /// <param name="moduleType">Type of module</param>
        /// <returns>Module</returns>
        Module GetModule(Type moduleType);

        /// <summary>
        /// Return module by type and name
        /// </summary>
        /// <param name="moduleType">Type of module</param>
        /// <param name="moduleName">Name of module</param>
        /// <returns>Module</returns>
        Module GetModule(Type moduleType, string moduleName);

        /// <summary>
        /// Return module by index
        /// </summary>
        /// <param name="index">Index of module</param>
        /// <returns>Module</returns>
        Module GetModule(int index);

        /// <summary>
        /// Return module by name
        /// </summary>
        /// <param name="moduleName">Name of module</param>
        /// <returns>Module</returns>
        Module GetModule(string moduleName);

        /// <summary>
        /// Return module by module item type
        /// </summary>
        /// <param name="moduleItemType">Module item type</param>
        /// <returns>Module</returns>
        Module GetModuleByItemType(Type moduleItemType);

        /// <summary>
        /// Return all modules
        /// </summary>
        /// <returns>All modules</returns>
        List<Module> GetModules();
    }
}

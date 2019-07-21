using ISUF.Base.Enum;
using ISUF.Base.Interface;
using ISUF.Base.Template;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.Base.Modules
{
    public class ModuleEnum : IModuleEnum
    {
        private ObservableCollection<Module> registeredModules = new ObservableCollection<Module>();

        //public ModuleEnum()
        //{
        //    registeredModules = new ObservableCollection<Module>();
        //}

        /// <summary>
        /// Check existence of module
        /// </summary>
        /// <param name="moduleType">Type of module</param>
        /// <returns>Existence of module</returns>
        public bool ExistModule(Type moduleType)
        {
            return registeredModules.Where(x => x.GetModuleType() == moduleType).Count() != 0;
        }

        /// <summary>
        /// Check existence of module
        /// </summary>
        /// <param name="moduleName">Name of module</param>
        /// <returns>Existence of module</returns>
        public bool ExistModule(string moduleName)
        {
            return registeredModules.Where(x => x.GetModuleName() == moduleName).Count() != 0;
        }

        /// <summary>
        /// Check existence of module
        /// </summary>
        /// <param name="moduleType">Type of module</param>
        /// <param name="moduleName">Name of module</param>
        /// <returns>Existence of module</returns>
        public bool ExistModule(Type moduleType, string moduleName)
        {
            if (moduleType == null || moduleName == null)
                return false;

            return registeredModules.Where(x => x.GetModuleName() == moduleName && x.GetModuleType() == moduleType).Count() != 0;
        }

        /// <summary>
        /// Check existence of module
        /// </summary>
        /// <param name="module">Module</param>
        /// <returns>Existence of module</returns>
        public bool ExistModule(Module module)
        {
            if (module == null)
                return false;

            return ExistModule(module.GetModuleType(), module.GetModuleName());
        }

        /// <summary>
        /// Return module by type
        /// </summary>
        /// <param name="moduleType">Type of module</param>
        /// <returns>Module</returns>
        public Module GetModule(Type moduleType)
        {
            return registeredModules.Where(x => x.GetModuleType() == moduleType).FirstOrDefault();
        }

        /// <summary>
        /// Return module by type and name
        /// </summary>
        /// <param name="moduleType">Type of module</param>
        /// <param name="moduleName">Name of module</param>
        /// <returns>Module</returns>
        public Module GetModule(Type moduleType, string moduleName)
        {
            return registeredModules.Where(x => x.GetModuleType() == moduleType && x.GetModuleName() == moduleName).FirstOrDefault();
        }

        /// <summary>
        /// Return module by name
        /// </summary>
        /// <param name="moduleName">Name of module</param>
        /// <returns>Module</returns>
        public Module GetModule(string moduleName)
        {
            return registeredModules.Where(x => x.GetModuleName() == moduleName).FirstOrDefault();
        }

        /// <summary>
        /// Return module by index
        /// </summary>
        /// <param name="index">Index of module</param>
        /// <returns>Module</returns>
        public Module GetModule(int index)
        {
            return registeredModules[index];
        }

        /// <summary>
        /// Return all modules
        /// </summary>
        /// <returns>All modules</returns>
        public List<Module> GetModules()
        {
            return new List<Module>(registeredModules);
        }

        /// <summary>
        /// Return count of modules
        /// </summary>
        /// <returns>Count of modules</returns>
        public int ModuleCount()
        {
            return registeredModules.Count;
        }

        /// <summary>
        /// Register module with selected type
        /// </summary>
        /// <param name="moduleType">Type of module</param>
        /// <returns>Registration completed succesfully</returns>
        public virtual bool RegisterModule(Type moduleType)
        {
            return RegisterModule(moduleType, moduleType.ToString());
        }

        /// <summary>
        /// Register module with selected type and name
        /// </summary>
        /// <param name="moduleType">Type of module</param>
        /// <param name="moduleName">Name of module</param>
        /// <returns>Registration completed succesfully</returns>
        public virtual bool RegisterModule(Type moduleType, string moduleName)
        {
            return RegisterModule(new Module(moduleType, moduleName));
        }

        /// <summary>
        /// Register module
        /// </summary>
        /// <param name="module">Module</param>
        /// <returns>Registration completed succesfully</returns>
        public virtual bool RegisterModule(Module module)
        {
            if (ExistModule(module))
                return false;

            registeredModules.Add(module);

            return true;
        }

        /// <summary>
        /// Remove module by type.
        /// </summary>
        /// <param name="moduleType">Type of module</param>
        /// <param name="removeAll">Remove all modules with same type</param>
        /// <returns>Operation completed succesfully</returns>
        public bool RemoveModule(Type moduleType, bool removeAll = false)
        {
            while (ExistModule(moduleType))
            {
                registeredModules.Remove(GetModule(moduleType));

                if (!removeAll)
                    break;
            }

            return true;
        }

        /// <summary>
        /// Remove module by type and name
        /// </summary>
        /// <param name="moduleType">Type of module</param>
        /// <param name="moduleName">Name of module</param>
        /// <returns>Operation completed succesfully</returns>
        public bool RemoveModule(Type moduleType, string moduleName)
        {
            if (ExistModule(moduleType, moduleName))
            {
                registeredModules.Remove(GetModule(moduleType, moduleName));
            }
            else
                return false;

            return true;
        }

        /// <summary>
        /// Remove module on selected index
        /// </summary>
        /// <param name="index">Index of module</param>
        /// <returns>Operation completed succesfully</returns>
        public bool RemoveModule(int index)
        {
            if (index < registeredModules.Count())
                registeredModules.RemoveAt(index);
            else
                return false;

            return true;
        }

        /// <summary>
        /// Remove module
        /// </summary>
        /// <param name="module">Module</param>
        /// <returns>Operation completed succesfully</returns>
        public bool RemoveModule(Module module)
        {
            if (ExistModule(module))
                registeredModules.Remove(GetModule(module.GetModuleType(), module.GetModuleName()));
            else
                return false;

            return true;
        }
    }
}

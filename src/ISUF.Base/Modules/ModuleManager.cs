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
    /// <summary>
    /// Base module manager
    /// </summary>
    public class ModuleManager : IModuleManager
    {
        protected ObservableCollection<Module> registeredModules = new ObservableCollection<Module>();

        /// <summary>
        /// Module analyser
        /// </summary>
        public ModuleAnalyser ModuleAnalyser { get; private set; }

        /// <summary>
        /// Initialize new Module Manager with Module analyser
        /// </summary>
        public ModuleManager()
        {
            ModuleAnalyser = new ModuleAnalyser();
        }
        
        /// <inheritdoc/>
        public bool ExistModule(Type moduleType)
        {
            return registeredModules.Where(x => x.ModuleItemType == moduleType).Count() != 0;
        }

        /// <inheritdoc/>
        public bool ExistModule(string moduleName)
        {
            return registeredModules.Where(x => x.ModuleName == moduleName).Count() != 0;
        }

        /// <inheritdoc/>
        public bool ExistModule(Type moduleType, string moduleName)
        {
            if (moduleType == null || moduleName == null)
                return false;

            return registeredModules.Where(x => x.ModuleName == moduleName && x.ModuleItemType == moduleType).Count() != 0;
        }

        /// <inheritdoc/>
        public bool ExistModule(Module module)
        {
            if (module == null)
                return false;

            return ExistModule(module.ModuleItemType, module.ModuleName);
        }

        /// <inheritdoc/>
        public Module GetModule(Type moduleType)
        {
            return registeredModules.Where(x => x.ModuleItemType == moduleType).FirstOrDefault();
        }

        /// <inheritdoc/>
        public Module GetModule(Type moduleType, string moduleName)
        {
            return registeredModules.Where(x => x.ModuleItemType == moduleType && x.ModuleName == moduleName).FirstOrDefault();
        }

        /// <inheritdoc/>
        public Module GetModule(string moduleName)
        {
            return registeredModules.Where(x => x.ModuleName == moduleName).FirstOrDefault();
        }

        /// <inheritdoc/>
        public Module GetModuleByItemType(Type moduleItemType)
        {
            return registeredModules.Where(x => x.ModuleItemType == moduleItemType).FirstOrDefault();
        }

        /// <inheritdoc/>
        public Module GetModule(int index)
        {
            return registeredModules[index];
        }

        /// <inheritdoc/>
        public List<Module> GetModules()
        {
            return new List<Module>(registeredModules);
        }

        /// <inheritdoc/>
        public int ModuleCount()
        {
            return registeredModules.Count;
        }

        /// <inheritdoc/>
        public virtual bool RegisterModule(Type moduleType)
        {
            return RegisterModule(moduleType, moduleType.ToString());
        }

        /// <inheritdoc/>
        public virtual bool RegisterModule(Type moduleType, string moduleName)
        {
            return RegisterModule(new Module(moduleType, moduleName));
        }

        /// <inheritdoc/>
        public virtual bool RegisterModule(Module module)
        {
            if (ExistModule(module))
                return false;

            module.SetModuleManager(this);

            registeredModules.Add(module);

            ModuleAnalyser.Analyse(module.ModuleItemType);

            return true;
        }

        /// <inheritdoc/>
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

        /// <inheritdoc/>
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

        /// <inheritdoc/>
        public bool RemoveModule(int index)
        {
            if (index < registeredModules.Count())
                registeredModules.RemoveAt(index);
            else
                return false;

            return true;
        }

        /// <inheritdoc/>
        public bool RemoveModule(Module module)
        {
            if (ExistModule(module))
                registeredModules.Remove(GetModule(module.ModuleItemType, module.ModuleName));
            else
                return false;

            return true;
        }
    }
}

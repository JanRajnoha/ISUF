using ISUF.Storage.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.UI.Modules
{
    class UIModuleManager : StorageModuleManager
    {
        public UIModuleManager(Type dbAccessType, string connectionString = "", bool useCache = false) : base(dbAccessType, connectionString, useCache)
        {
        }
    }
}

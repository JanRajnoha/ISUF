using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.Storage.Modules
{
    class UserModule : StorageModule
    {
        public UserModule(Type moduleItemType, Type itemManagerType, string moduleTableName = null) : base(moduleItemType, itemManagerType, moduleTableName)
        {
        }

        public UserModule(Type moduleItemType, string moduleName, Type itemManagerType, string moduleTableName = null) : base(moduleItemType, moduleName, itemManagerType, moduleTableName)
        {
        }
    }
}

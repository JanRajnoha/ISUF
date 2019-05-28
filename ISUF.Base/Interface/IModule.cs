using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.Base.Interface
{
    interface IModule
    {
        Type GetModuleType();

        string GetModuleName();
    }
}

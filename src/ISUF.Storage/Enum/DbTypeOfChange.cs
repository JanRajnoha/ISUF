using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.Storage.Enum
{
    /// <summary>
    /// Enum of database changes
    /// </summary>
    public enum DbTypeOfChange
    {
        Add,
        Edit,
        Remove,
        CreateTable,
        UpdateTable,
        RemoveTable
    }
}

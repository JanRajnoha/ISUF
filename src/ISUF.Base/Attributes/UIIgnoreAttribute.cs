using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.Base.Attributes
{
    /// <summary>
    /// Attribute for ignoring property in UI
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class UIIgnoreAttribute : Attribute
    {

    }
}

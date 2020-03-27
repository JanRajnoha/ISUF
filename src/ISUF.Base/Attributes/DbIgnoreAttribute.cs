using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.Base.Attributes
{
    /// <summary>
    /// Attribute for ignotring attribute in database
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class DbIgnoreAttribute : Attribute
    {

    }
}

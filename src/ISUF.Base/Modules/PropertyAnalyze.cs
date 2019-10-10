using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.Base.Modules
{
    public class PropertyAnalyze
    {
        public string PropertyName { get; set; }
        public Type PropertyType { get; set; }
        public List<Type> PropertyAttributes { get; set; }

        public PropertyAnalyze(string name, Type type, List<Type> attributes)
        {
            PropertyName = name;
            PropertyType = type;
            PropertyAttributes = attributes;
        }
    }
}

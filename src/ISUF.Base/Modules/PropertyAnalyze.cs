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

        public override bool Equals(object obj)
        {
            if (obj is PropertyAnalyze propAnal)
            {
                return PropertyName == propAnal.PropertyName &&
                    PropertyType == propAnal.PropertyType &&
                    PropertyAttributes.TrueForAll(x => propAnal.PropertyAttributes.Contains(x));
            }
            else
                return false;
        }
    }
}

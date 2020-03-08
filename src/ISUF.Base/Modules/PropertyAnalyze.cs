using ISUF.Base.Enum;
using ISUF.Base.Exceptions;
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
        public PropertyType PropertyType { get; set; }
        public List<object> PropertyAttributes { get; set; }
        private Type fullPropertyType;

        public PropertyAnalyze(string name, Type type, List<object> attributes)
        {
            fullPropertyType = type;

            PropertyName = name;
            PropertyType = PropertyTypeNameToEnum(fullPropertyType);
            PropertyAttributes = attributes;
        }

        public override bool Equals(object obj)
        {
            if (obj is PropertyAnalyze propAnal)
            {
                return PropertyName == propAnal.PropertyName &&
                    PropertyType == propAnal.PropertyType &&
                    PropertyAttributes.TrueForAll(x => propAnal.PropertyAttributes.FirstOrDefault(y => y.GetType() == x.GetType()).Equals(x));
            }
            else
                return false;
        }

        private PropertyType PropertyTypeNameToEnum(Type propertyType)
        {
            List<PropertyType> propTypeEnumValuesList = System.Enum.GetValues(typeof(PropertyType)).Cast<PropertyType>().ToList();
            var result = propTypeEnumValuesList.FirstOrDefault(x => x.ToString().ToLower() == propertyType.Name.ToLower());

            if (result == null)
                throw new NotSupportedPropertyTypeException("Not supported PropertyType.");

            return result;
        }
    }
}

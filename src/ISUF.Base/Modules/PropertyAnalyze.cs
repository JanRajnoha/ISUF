using ISUF.Base.Enum;
using ISUF.Base.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.Base.Modules
{
    /// <summary>
    /// Analyze of property
    /// </summary>
    public class PropertyAnalyze
    {
        public string PropertyName { get; set; }
        public PropertyType PropertyType { get; set; }
        public List<object> PropertyAttributes { get; set; }

        private readonly Type fullPropertyType;

        /// <summary>
        /// Initialize new PropertyAnalyze
        /// </summary>
        /// <param name="name">Property name</param>
        /// <param name="type">Property type</param>
        /// <param name="attributes">Attributes of property</param>
        public PropertyAnalyze(string name, Type type, List<object> attributes)
        {
            fullPropertyType = type;

            PropertyName = name;
            PropertyType = PropertyTypeNameToEnum(fullPropertyType);
            PropertyAttributes = attributes;
        }

        /// <inheritdoc/>
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

        /// <summary>
        /// Convert property type to <see cref="PropertyType"/>
        /// </summary>
        /// <param name="propertyType">Property type</param>
        /// <returns>Value of PropertyType enum</returns>
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

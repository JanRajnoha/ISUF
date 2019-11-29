using ISUF.Base.Attributes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.Base.Modules
{
    public class ModuleAnalyser
    {
        Type analysedClassType;
        Dictionary<string, PropertyAnalyze> analysedClassDictionary;

        public ModuleAnalyser(Type analysedClass)
        {
            analysedClassType = analysedClass;
        }

        public Dictionary<string, PropertyAnalyze> Analyze()
        {
            if (analysedClassDictionary == null)
                DoAnalysis();

            return analysedClassDictionary;
        }

        private void DoAnalysis()
        {
            analysedClassDictionary = new Dictionary<string, PropertyAnalyze>();

            foreach (var prop in analysedClassType.GetProperties())
            {
                var attributes = prop.GetCustomAttributes(true).ToList();

                var analyze = new PropertyAnalyze(prop.Name, prop.PropertyType, attributes);

                analysedClassDictionary.Add(prop.Name, analyze);
            }
        }

        public List<KeyValuePair<string, PropertyAnalyze>> SortProperties()
        {
            var orderPropertyList = new List<PropertyAnalyze>();

            var propsNoUiOrder = analysedClassDictionary.Values.Where(x => x.PropertyAttributes.FirstOrDefault(y => y.GetType() == typeof(UIParamsAttribute)) == null);
            var propsWithUiOrder = analysedClassDictionary.Values.Where(x => x.PropertyAttributes.FirstOrDefault(y => y.GetType() == typeof(UIParamsAttribute)) != null);

            foreach (var property in propsWithUiOrder.OrderBy(x => (x.PropertyAttributes.FirstOrDefault(y => y.GetType() == typeof(UIParamsAttribute)) as UIParamsAttribute).UIOrder))
            {
                var propUiCustomization = property.PropertyAttributes.FirstOrDefault(x => x.GetType() == typeof(UIParamsAttribute)) as UIParamsAttribute;
                var propUiOrder = propUiCustomization.UIOrder;

                if (propUiOrder > orderPropertyList.Count)
                    propUiOrder = orderPropertyList.Count;

                orderPropertyList.Insert(propUiOrder, property);
            }

            foreach (var property in propsNoUiOrder)
            {
                orderPropertyList.Insert(0, property);
            }

            var result = new List<KeyValuePair<string, PropertyAnalyze>>();

            foreach (var property in orderPropertyList)
            {
                var dictionaryItem = analysedClassDictionary.FirstOrDefault(x => x.Value == property);
                result.Add(dictionaryItem);
            }

            return result;
        }
    }
}

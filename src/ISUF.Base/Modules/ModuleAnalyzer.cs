using ISUF.Base.Attributes;
using ISUF.Base.Exceptions;
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
        Dictionary<Type, Dictionary<string, PropertyAnalyze>> analysedClassesDictionary = new Dictionary<Type, Dictionary<string, PropertyAnalyze>>();

        public ModuleAnalyser()
        {

        }

        public Dictionary<string, PropertyAnalyze> AnalyseAndGet(Type analysedClass)
        {
            if (!analysedClassesDictionary.ContainsKey(analysedClass))
                DoAnalysis(analysedClass);

            return analysedClassesDictionary[analysedClass];
        }

        public void Analyse(Type analysedClass)
        {
            _ = AnalyseAndGet(analysedClass);
        }

        private void DoAnalysis(Type analysedClass)
        {
            Dictionary<string, PropertyAnalyze> analysedClassDictionary = new Dictionary<string, PropertyAnalyze>();
            List<Type> linkedTablesRelations = new List<Type>();

            foreach (var prop in analysedClass.GetProperties())
            {
                var attributes = prop.GetCustomAttributes(true).ToList();

                if (attributes.Contains(typeof(DbIgnoreAttribute)) && attributes.Contains(typeof(LinkedTableAttribute)))
                    throw new NotSupportedAttributeCombinationException("Linked tables properties can't be ignored in DB.");

                LinkedTableAttribute linkedTableInfo = attributes.FirstOrDefault(x => x.GetType() == typeof(LinkedTableAttribute)) as LinkedTableAttribute;

                if (linkedTableInfo != null)
                {
                    if ((linkedTableInfo.LinkedTableRelation == Enum.LinkedTableRelation.Many && prop.PropertyType != typeof(List<int>)) ||
                    (linkedTableInfo.LinkedTableRelation == Enum.LinkedTableRelation.One && prop.PropertyType != typeof(int)))
                        throw new NotSupportedAttributeCombinationException("Property type can't be used with this type of Linked Table attribute");

                    if (linkedTablesRelations.Contains(linkedTableInfo.LinkedTableType))
                        throw new NotSupportedAttributeCombinationException("Only one linked table relation for linked table.");
                    else
                        linkedTablesRelations.Add(linkedTableInfo.LinkedTableType);
                }

                UIParamsAttribute uiParams = attributes.FirstOrDefault(x => x.GetType() == typeof(UIParamsAttribute)) as UIParamsAttribute;

                if (uiParams != null && string.IsNullOrEmpty(uiParams.LabelDescription) && uiParams.UseLabelDescription)
                    throw new NotSupportedAttributeCombinationException("UIParams attribute must specify LabelDescription if UseLabelDescription is true.");

                var analyze = new PropertyAnalyze(prop.Name, prop.PropertyType, attributes);

                analysedClassDictionary.Add(prop.Name, analyze);
            }

            analysedClassesDictionary.Add(analysedClass, analysedClassDictionary);
        }

        public List<KeyValuePair<string, PropertyAnalyze>> SortProperties(Type analysedClass)
        {
            if (!analysedClassesDictionary.ContainsKey(analysedClass))
                throw new Exceptions.ArgumentException("Required class has not been analysed.");

            var orderPropertyList = new List<PropertyAnalyze>();

            var propsNoUiOrder = analysedClassesDictionary[analysedClass].Values.Where(x => x.PropertyAttributes.FirstOrDefault(y => y.GetType() == typeof(UIParamsAttribute)) == null);
            var propsWithUiOrder = analysedClassesDictionary[analysedClass].Values.Where(x => x.PropertyAttributes.FirstOrDefault(y => y.GetType() == typeof(UIParamsAttribute)) != null);

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
                var dictionaryItem = analysedClassesDictionary[analysedClass].FirstOrDefault(x => x.Value == property);
                result.Add(dictionaryItem);
            }

            return result;
        }
    }
}

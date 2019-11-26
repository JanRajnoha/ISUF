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
    }
}

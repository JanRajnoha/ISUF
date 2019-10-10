using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.Base.Modules
{
    public class ModuleAnalyzer
    {
        public Dictionary<string, PropertyAnalyze> Analyze(Type analyzedClass)
        {
            var dict = new Dictionary<string, PropertyAnalyze>();

            foreach (var prop in analyzedClass.GetProperties())
            {
                var attributes = prop.GetCustomAttributes(true).Select(x => x.GetType()).ToList();

                var analyze = new PropertyAnalyze(prop.Name, prop.PropertyType, attributes);

                dict.Add(prop.Name, analyze);
            }

            return dict;
        }
    }
}

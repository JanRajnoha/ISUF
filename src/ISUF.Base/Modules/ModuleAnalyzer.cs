using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.Base.Modules
{
    public class ModuleAnalyzer
    {
        public Dictionary<string, Type> Analyze(Type analyzedClass)
        {
            var dict = new Dictionary<string, Type>();

            foreach (var prop in analyzedClass.GetProperties())
            {
                dict.Add(prop.Name, prop.PropertyType);
            }

            return dict;
        }
    }
}

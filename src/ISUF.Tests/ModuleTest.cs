using ISUF.Base.Attributes;
using ISUF.Base.Modules;
using ISUF.Base.Template;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.Tests
{

    [TestClass]
    public class ModuleTest
    {
        ModuleManager mEnum = new ModuleManager();
        Module mod;

        [TestMethod]
        [Priority(0)]
        public void AnalyzerTest()
        {
            ModuleAnalyzer analyzer = new ModuleAnalyzer();

            var analyzeResult = analyzer.Analyze(typeof(TestClassNotBaseItem));

            PropertyAnalyze prop1 = new PropertyAnalyze("StringProp", typeof(string), new List<Type>()
            {
                typeof(UIIgnoreAttribute),
                typeof(DbIgnoreAttribute)
            });

            PropertyAnalyze prop2 = new PropertyAnalyze("IntProp", typeof(int), new List<Type>());

            Assert.IsTrue(analyzeResult.Values.ToList()[0].Equals(prop1));
            Assert.IsTrue(analyzeResult.Values.ToList()[1].Equals(prop2));
        }

        [TestMethod]
        [Priority(1)]
        public void AddModuleTest()
        {
            CreateModuleTest();

            Assert.IsTrue(mEnum.ModuleCount() == 0);

            mEnum.RegisterModule(mod);

            Assert.IsTrue(mEnum.ModuleCount() != 0);
        }

        [TestMethod]
        [Priority(2)]
        public void CreateModuleTest()
        {
            Assert.IsNull(mod);

            mod = new Module(typeof(TestClass));

            Assert.IsNotNull(mod);
        }
    }

    public class TestClass : AtomicItem
    {
        public string StringProp { get; set; }

        public int IntProp { get; set; }
    }

    public class TestClass2 : AtomicItem
    {
        public string StringProp { get; set; }

        public double DoubleProp { get; set; }
    }

    public class TestClassNotBaseItem
    {
        [UIIgnore]
        [DbIgnore]
        public string StringProp { get; set; }

        public int IntProp { get; set; }
    }
}
using ISUF.Base.Modules;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
        ModuleEnum mEnum = new ModuleEnum();
        Module mod;
        
        [TestMethod]
        [Priority(0)]
        public void AnalyzerTest()
        {
            ModuleAnalyzer analyzer = new ModuleAnalyzer();

            var analyzeResult = analyzer.Analyze(typeof(TestClass));

            var expextedResult = new Dictionary<string, Type>
            {
                { "StringProp", typeof(string) },
                { "IntProp", typeof(int) },
            };

            Assert.IsTrue(expextedResult.ToList().SequenceEqual(analyzeResult.ToList()));
        }

        [TestMethod]
        [Priority(2)]
        public void AddModuleTest()
        {
            Assert.IsTrue(mEnum.ModuleCount() == 0);

            mEnum.RegisterModule(mod);

            Assert.IsTrue(mEnum.ModuleCount() != 0);
        }

        [TestMethod]
        [Priority(3)]
        public void CreateModuleTest()
        {
            Assert.IsNull(mod);

            mod = new Module(typeof(TestClass));

            Assert.IsNotNull(mod);
        }
    }

    public class TestClass
    {
        public string StringProp { get; set; }

        public int IntProp { get; set; }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TreeDBNS;

namespace TreeDBNS.Tests {
    [TestClass]
    public class TreeDBTest {
        [TestMethod]
        public void TestInit1() {
            TreeDB db = new TreeDB("TestDB");
            Assert.AreEqual("TestDB", db.getName());
        }

        [TestMethod]
        public void TestInit2() {
            TreeDB db2 = new TreeDB("TestDB2");
            Assert.AreEqual("TestDB2", db2.getName());
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TreeDBNS;

namespace TreeDBNS.Tests {
    [TestClass]
    public class TreeTest {
        private TreeDB? db;
        [TestInitialize]
        public void BeforeEach() {
            db = new TreeDB("DB");
        }

        [TestMethod]
        public void TreeInit1() {
            db.addTree("Tree");
            Assert.AreEqual("Tree", db.getActiveName());
        }

        [TestMethod]
        public void TreeInit2() {
            db.addTree("Tree2");
            Assert.AreEqual("Tree2", db.getActiveName());
        }

        [TestMethod]
        public void TreeInit3() {
            db.addTree("Tree");
            db.addTree("Tree 2");
            db.setActive("Tree 2");
            Assert.AreEqual("Tree 2", db.getActiveName());
        }
    }
}

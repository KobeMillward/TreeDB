using Microsoft.VisualStudio.TestTools.UnitTesting;
using TreeDBNS;

namespace TreeDBNS.Tests {
    [TestClass]
    public class TreeTest {
        [TestMethod]
        public void TreeInit1() {
            Tree tree = new Tree("Tree");
            Assert.AreEqual("Tree", tree.getName());
        }

        [TestMethod]
        public void TreeInit2() {
            Tree tree2 = new Tree("Tree2");
            Assert.AreEqual("Tree2", tree2.getName());
        }
        
        [TestMethod]
        public void TestRoot1() {
            Tree tree = new Tree("Tree");
            Assert.AreEqual(null, tree.getRoot());
        }

        [TestMethod]
        public void TestRoot2() {
            Tree tree = new Tree("Tree");
            Assert.IsTrue(tree.addNode(5, tree.getRoot()));
            Assert.AreEqual(5, tree.getRoot().getKey());
        }

        [TestMethod]
        public void TestRoot3() {
            Tree tree = new Tree("Tree");
            Assert.IsTrue(tree.addNode("TestString", tree.getRoot()));
            Assert.AreEqual("TestString", tree.getRoot().getKey());
        }

        [TestMethod]
        public void TestRoot4() {
            Tree tree = new Tree("Tree");
            Assert.IsTrue(tree.addNode(false, tree.getRoot()));
            Assert.AreEqual(false, tree.getRoot().getKey());
        }

        [TestMethod]
        public void TestRoot5() {
            Tree tree = new Tree("Tree");
            Assert.IsTrue(tree.addNode(0b00000000, tree.getRoot()));
            Assert.AreEqual(0b00000000, tree.getRoot().getKey());
        }
    }
}
